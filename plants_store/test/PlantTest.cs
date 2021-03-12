 namespace PlantTest.Tests
{
    public class PlantControllerTests
    {
        [Fact]
        public void IndexReturnsAListOfPlants()
        {
            // Arrange
            var mock = new Mock<IRepository>();
            mock.Setup(repo => repo.GetAll()).Returns(GetTestPlants());
            var controller = new HomeController(mock.Object);
 
            // Act
            var result = controller.Index();
 
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Plant>>(
                viewResult.Model);
            Assert.Equal(GetTestPlants().Count, model.Count());
        }
        private List<Plant> GetTestPlants()
        {
            var plants = new List<Plant>
            {
                new Plant { Id=1, Name="Tom", Description=”087654”},
                new Plant { Id=2, Name="Kate", Description=”6789”}
            };
            Return plants;
        }
        [Fact]
        public void GetPlantReturnsBadRequestResultWhenIdIsNull()
        {
            // Arrange
            var mock = new Mock<IRepository>();
            var controller = new PlantController(mock.Object);
 
            // Act
            var result = controller.GetPlant(null);
 
            // Arrange
            Assert.IsType<BadRequestResult>(result);
        }
 
       [Fact]
        public void GetPlantReturnsNotFound ()
        {
            // Arrange
            int testPlantId = 8;
            var mock = new Mock<IRepository>();
            mock.Setup(repo => repo.Get(testPlantId))
                .Returns(null as User);
            var controller = new PlantController(mock.Object);
 
            // Act
            var result = controller.GetPlant(testPlantId);
 
            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

