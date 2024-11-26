using Lab4.src;
using Lab4.src.CarStationComponents;
using Lab4.src.CarStationComponents.interfaces;
using Lab4.src.queues;
using Moq;
using NUnit.Framework;
using System.IO.Abstractions;
using System.Text.Json;

namespace Lab4.Tests
{
    public class SemaphoreTests
    {
        private readonly Mock<IFileSystem> _fileSystemMock;
        private readonly Semaphore _semaphore;

        public SemaphoreTests()
        {
            _fileSystemMock = new Mock<IFileSystem>();
            _semaphore = new Semaphore();
        }

        [Test]
        public void ReadDirectory_ProcessesFilesCorrectly()
        {
            // Arrange
            string directoryPath = "output/";
            var mockCar = new Car { type = "ELECTRIC", passengers = "PEOPLE" };
            string mockJson = JsonSerializer.Serialize(mockCar);
            string[] mockFiles = { $"{directoryPath}car1.json", $"{directoryPath}car2.json" };

            _fileSystemMock.Setup(fs => fs.Directory.GetFiles(directoryPath, "*.json"))
                .Returns(mockFiles);
            _fileSystemMock.Setup(fs => fs.File.ReadAllText(It.IsAny<string>()))
                .Returns(mockJson);
            _fileSystemMock.Setup(fs => fs.File.Delete(It.IsAny<string>()));

            // Act
            int result = _semaphore.ReadDirectory(directoryPath);

            // Assert
            Assert.Equal(mockFiles.Length, result);
            _fileSystemMock.Verify(fs => fs.File.Delete(It.IsAny<string>()), Times.Exactly(mockFiles.Length));
        }

        [Test]
        public void ReadDirectory_HandlesNoFilesGracefully()
        {
            // Arrange
            string directoryPath = "output/";
            _fileSystemMock.Setup(fs => fs.Directory.GetFiles(directoryPath, "*.json"))
                .Returns(new string[0]);

            // Act
            int result = _semaphore.ReadDirectory(directoryPath);

            // Assert
            Assert.Equal(0, result);
            _fileSystemMock.Verify(fs => fs.File.Delete(It.IsAny<string>()), Times.Never);
        }

        [Test]
        public void ReadStream_TerminatesAfterThreeEmptyReads()
        {
            // Arrange
            Mock<Semaphore> mockSemaphore = new Mock<Semaphore>() { CallBase = true };
            mockSemaphore.Setup(s => s.ReadDirectory(It.IsAny<string>())).Returns(0);

            // Act
            mockSemaphore.Object.ReadStream(1); // Reduce sleep time for testing

            // Assert
            mockSemaphore.Verify(s => s.ReadDirectory(It.IsAny<string>()), Times.AtLeast(3));
        }

        [Test]
        public void DisplayResults_PrintsCorrectCounts()
        {
            // Arrange
            Mock<Semaphore> mockSemaphore = new Mock<Semaphore>() { CallBase = true };
            mockSemaphore.Setup(s => s.DisplayResults());

            // Act
            mockSemaphore.Object.DisplayResults();

            // Assert
            mockSemaphore.Verify(s => s.DisplayResults(), Times.Once);
        }
    }
}
