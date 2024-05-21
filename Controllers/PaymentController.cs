// Controllers/PaymentsController.cs
using Microsoft.AspNetCore.Mvc;
using PMS_NET1.Models.Payment;
using System.Collections.Generic;
using System.Linq;

namespace PMS_NET1.Controllers
{
    [Route("payments")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private static List<Payment> Payments = new List<Payment>
        {
            new Payment { Id = 1, PaymentType = "Credit Card", Amount = 100.50m, PaymentDate = DateTime.Now, Status = "Completed" },
            new Payment { Id = 2, PaymentType = "PayPal", Amount = 200.75m, PaymentDate = DateTime.Now, Status = "Pending" }
        };

        // GET: payments
        [HttpGet]
        public ActionResult<IEnumerable<Payment>> GetPayments()
        {
            return Ok(Payments);
        }

        // GET: payments/{id}
        [HttpGet("{id}")]
        public ActionResult<Payment> GetPayment(int id)
        {
            var payment = Payments.FirstOrDefault(p => p.Id == id);
            if (payment == null)
            {
                return NotFound();
            }
            return Ok(payment);
        }

        // POST: payments
        [HttpPost]
        public ActionResult<Payment> CreatePayment([FromBody] Payment payment)
        {
            payment.Id = Payments.Count > 0 ? Payments.Max(p => p.Id) + 1 : 1;
            Payments.Add(payment);
            return CreatedAtAction(nameof(GetPayment), new { id = payment.Id }, payment);
        }

        // PUT: payments/{id}
        [HttpPut("{id}")]
        public ActionResult UpdatePayment(int id, [FromBody] Payment updatedPayment)
        {
            var payment = Payments.FirstOrDefault(p => p.Id == id);
            if (payment == null)
            {
                return NotFound();
            }

            payment.PaymentType = updatedPayment.PaymentType;
            payment.Amount = updatedPayment.Amount;
            payment.PaymentDate = updatedPayment.PaymentDate;
            payment.Status = updatedPayment.Status;

            return NoContent();
        }

        // DELETE: payments/{id}
        [HttpDelete("{id}")]
        public ActionResult DeletePayment(int id)
        {
            var payment = Payments.FirstOrDefault(p => p.Id == id);
            if (payment == null)
            {
                return NotFound();
            }

            Payments.Remove(payment);
            return NoContent();
        }
    }
}
