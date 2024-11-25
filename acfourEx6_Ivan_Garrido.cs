namespace acfour_Ivan_Garrido_Test
{
    [TestClass]
    public class OrdenacioTests
    {
        [TestMethod]
        public void OrdenarAscendent_FuncionaCorrectament()
        {
            // Arrange
            int[] nombres = { 8, 2, 5, 1, 7 };
            int[] esperat = { 1, 2, 5, 7, 8 };

            // Act
            Array.Sort(nombres);

            // Assert
            CollectionAssert.AreEqual(esperat, nombres);
        }

        [TestMethod]
        public void OrdenarDescendent_FuncionaCorrectament()
        {
            // Arrange
            // Numeros per comprobar
            int[] nombres = { 8, 2, 5, 1, 7 };
            int[] esperat = { 8, 7, 5, 2, 1 };

            // Act
            Array.Sort(nombres); 
            Array.Reverse(nombres); 

            // Assert
            CollectionAssert.AreEqual(esperat, nombres);
        }

        [TestMethod]
        public void OrdenarAscendent_ArrayBuit()
        {
            // Arrange
            int[] nombres = { };
            int[] esperat = { };

            // Act
            Array.Sort(nombres);

            // Assert
            CollectionAssert.AreEqual(esperat, nombres);
        }

        [TestMethod]
        public void OrdenarDescendent_ArrayAmbUnElement()
        {
            // Arrange
            // Numeros de prova per el test
            int[] nombres = { 42 };
            int[] esperat = { 42 };

            // Act
            Array.Sort(nombres);
            Array.Reverse(nombres);

            // Assert
            CollectionAssert.AreEqual(esperat, nombres);
        }
    }

}

