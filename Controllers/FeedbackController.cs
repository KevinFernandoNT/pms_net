using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

[Route("feedback")]
[ApiController]
public class FeedbackController : ControllerBase
{
    private static readonly List<Feedback> _feedbacks = new List<Feedback>
    {
        new Feedback { Id = 1, Date = new DateTime(2024, 4, 25), GuestName = "John Doe", RoomNumber = "102", FeedbackCategory = "Service", FeedbackDescription = "The staff promptly attended to my requests and were very polite throughout my stay." },
        new Feedback { Id = 2, Date = new DateTime(2024, 4, 24), GuestName = "Jane Smith", RoomNumber = "202", FeedbackCategory = "Service", FeedbackDescription = "While check-in was smooth, the staff seemed overwhelmed during breakfast, in long wait times." },
        new Feedback { Id = 3, Date = new DateTime(2024, 4, 23), GuestName = "Mike Johnson", RoomNumber = "206", FeedbackCategory = "Food", FeedbackDescription = "Although the breakfast spread was decent, some of the items seemed stale, and the coffee tasted burnt." },
        new Feedback { Id = 4, Date = new DateTime(2024, 4, 22), GuestName = "Emily Brown", RoomNumber = "101", FeedbackCategory = "Food", FeedbackDescription = "I was disappointed with the quality of the food at the hotel restaurant." },
        new Feedback { Id = 5, Date = new DateTime(2024, 4, 22), GuestName = "Floor -1", RoomNumber = "098", FeedbackCategory = "Facilities", FeedbackDescription = "The gym facilities were well-maintained and had a good selection of equipment." },
        new Feedback { Id = 6, Date = new DateTime(2024, 4, 22), GuestName = "Floor -2", RoomNumber = "145", FeedbackCategory = "Facilities", FeedbackDescription = "The pool area was crowded and noisy, making it difficult to relax and enjoy the ambiance." },
        new Feedback { Id = 7, Date = new DateTime(2024, 4, 22), GuestName = "Floor -3", RoomNumber = "112", FeedbackCategory = "Food", FeedbackDescription = "The dinner buffet had a wide variety of options, and the food was delicious." },
        new Feedback { Id = 8, Date = new DateTime(2024, 4, 22), GuestName = "Floor -5", RoomNumber = "134", FeedbackCategory = "Service", FeedbackDescription = "The concierge provided excellent recommendations for local attractions." }
    };

    // GET: api/feedback
    [HttpGet]
    public ActionResult<IEnumerable<Feedback>> GetFeedbacks()
    {
        return _feedbacks;
    }

    // GET: api/feedback/1
    [HttpGet("{id}")]
    public ActionResult<Feedback> GetFeedback(int id)
    {
        var feedback = _feedbacks.FirstOrDefault(f => f.Id == id);
        if (feedback == null)
        {
            return NotFound();
        }
        return feedback;
    }

    // POST: api/feedback
    [HttpPost]
    public ActionResult<Feedback> CreateFeedback([FromBody] Feedback feedback)
    {
        feedback.Id = _feedbacks.Max(f => f.Id) + 1;
        _feedbacks.Add(feedback);
        return CreatedAtAction(nameof(GetFeedback), new { id = feedback.Id }, feedback);
    }

    // PUT: api/feedback/1
    [HttpPut("{id}")]
    public IActionResult UpdateFeedback(int id, [FromBody] Feedback updatedFeedback)
    {
        var feedback = _feedbacks.FirstOrDefault(f => f.Id == id);
        if (feedback == null)
        {
            return NotFound();
        }

        feedback.Date = updatedFeedback.Date;
        feedback.GuestName = updatedFeedback.GuestName;
        feedback.RoomNumber = updatedFeedback.RoomNumber;
        feedback.FeedbackCategory = updatedFeedback.FeedbackCategory;
        feedback.FeedbackDescription = updatedFeedback.FeedbackDescription;

        return NoContent();
    }

    // DELETE: api/feedback/1
    [HttpDelete("{id}")]
    public IActionResult DeleteFeedback(int id)
    {
        var feedback = _feedbacks.FirstOrDefault(f => f.Id == id);
        if (feedback == null)
        {
            return NotFound();
        }

        _feedbacks.Remove(feedback);
        return NoContent();
    }
}
