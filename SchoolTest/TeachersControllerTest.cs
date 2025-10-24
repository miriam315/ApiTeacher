using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using School.Controllers;
using School.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTest
{
    public class TeachersControllerTest
    {
        public FakeContext fakeContext = new FakeContext();
        [Fact]
        public void Get_RteurnList()
        {
            //AAA
            //ARRANGE

            //ACT
            var controller = new TeachersController(fakeContext);
            var result = controller.Get();

            //ASSERT
            Assert.IsType<List<Teachers>>(result);
        }

        [Fact]
        public void Get_RteurnCount()
        {
            //AAA
            //ARRANGE

            //ACT
            var controller = new TeachersController(fakeContext);
            var result = controller.Get();

            //ASSERT
            Assert.Equal(2,result.Count());
        }

        [Fact]
        public void GetById_RteurnOk()
        {
            //AAA
            //ARRANGE
            var id = 2;
            //ACT
            var controller = new TeachersController(fakeContext);
            var result = controller.Get(id);

            //ASSERT
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetById_RteurnNotFound()
        {
            //AAA
            //ARRANGE
            var id = 8;
            //ACT
            var controller = new TeachersController(fakeContext);
            var result = controller.Get(id);

            //ASSERT
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
