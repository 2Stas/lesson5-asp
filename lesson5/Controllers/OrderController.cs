using lesson5.Services;
using lesson5.Models;
using Microsoft.AspNetCore.Mvc;
using lesson5.DTO;

namespace lesson5.Controllers
{
    [Route("api/Order")]
    public class OrderController : Controller
    {
        private IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            var list = orderService.GetAll();

            return View("Index", list);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var order = orderService.GetById(id);

            if (order == null)
            {
                return NotFound();
            }

            return View("Details", order);
        }

        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("Create")]
        public IActionResult Create(CreateOrderDto order)
        {
            var createdOrder = orderService.Create(order);

            return View("Details", createdOrder);
        }

        [HttpGet("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var order = orderService.GetById(id);

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        [HttpPost("Delete/{id}")]
        public IActionResult DeleteConfirmed(int id)
        {
            var deletedOrder = orderService.Delete(id);

            if (deletedOrder == null)
            {
                return NotFound();
            }

            return View("Index");
        }

        [HttpGet("UpdateStatus/{id}")]
        public IActionResult UpdateStatus(int id)
        {
            var order = orderService.GetById(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }



        [HttpPost("UpdateStatus/{id}")]
        public IActionResult UpdateStatus(int id, string status)
        {
            var updatedOrder = orderService.UpdateStatus(id, status);
            if (updatedOrder == null)
            {
                return NotFound();
            }
            return View("Details", updatedOrder);
        }
    }
}