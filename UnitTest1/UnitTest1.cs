using Microsoft.AspNetCore.Mvc;
using MyProject.Controllers;
using MyProject.Entities;
using MyProject.Services;
using UnitTest;

namespace UnitTest1
{
    public class UnitTest1
    {
        [Fact]
        public void Get_ReturnOkResult()
        {
            var controller = new UserController(new UserService(new FakeContext()));
            var result = controller.Get();
            //Assert.IsType<ActionResult<List<MyProject.Entities.User>>>(result.Result);
            Assert.IsType<ActionResult<List<User>>>(result);
            //Assert.Equal(1, result.Count());

        }
        [Fact]
        public void GetById_ReturnsNotNull()
        {
            var controller = new UserController(new UserService(new FakeContext()));
            var result = controller.Get(1);
            Assert.NotEqual(null,result.Value);
        }
        [Fact]
        public void Post_ReturnOkResult()
        {
            var controller = new UserController(new UserService(new FakeContext()));
            var result = controller.Post(new User("fact", "fact",  "factEmail", "065939597", "factPassWord", "factPhone", "factAddress", MyProject.Enum.AccountType.VISA, true));
            //Assert.IsAssignableFrom<ActionResult>(result3);
            //Assert.IsType<OkResult>(result);
            Assert.Equal(true, result.Value);
        }
        [Fact]
        public void Put_ReturnOkResult()
        {
            var controller = new UserController(new UserService(new FakeContext()));
            var result = controller.Put(1, new User("fact", "fact",  "factEmail", "065939597", "factPassWord", "factPhone", "factAddress", MyProject.Enum.AccountType.VISA, true));
            //Assert.IsAssignableFrom<ActionResult>(result3);
            Assert.Equal(true,result.Value);
        }
        [Fact]
        public void Delete_ReturnOkResult()
        {
            var controller = new UserController(new UserService(new FakeContext()));
            var result = controller.Delete(1);
            Assert.IsType<bool>(result.Value);
        }
        [Fact]
        public void Tz_Valid_ErrorResult()
        {
            string tz = "01234678p";
            ErrorTZ reason;
            new TzValid().ISOK(tz, out reason);
            Assert.Equal(ErrorTZ.NotInt, reason);
            tz = "3216547";
            new TzValid().ISOK(tz, out reason);
            Assert.Equal(ErrorTZ.LengthNotValid, reason);
            tz = "000000044";
            new TzValid().ISOK(tz, out reason);
            Assert.Equal(ErrorTZ.DigitsNotOk, reason);
            tz = "329146518";
            new TzValid().ISOK(tz, out reason);
            Assert.Equal(ErrorTZ.OK, reason);
        }
    }
}