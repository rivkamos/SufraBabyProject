using DotoList.Controllers;
using DotoList.Interfaces;
using DotoList.Services;

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

        [Fact]
        public void Login_withoutid_sms()
        {
            //AAA
            string x = "";
            var userMsgController = new UserMsgController(new SmsService());
            var res = userMsgController.MsgLogin(x);
            Assert.IsType<string>(res);
        }

    }
}