using DotoList.Controllers;

namespace TestProject
{
    public class BabyUnitTest
    {

        [Fact]
        public void Dup_divByZero()
        {
            //AAA
            int x = 2;
            int y = 0;
            var babyController = new BabyController();

            var res =  babyController.Dup(x, y);
            
            Assert.Equal(res, 0);
        }



    }
}