using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

[Route("roomTransfer")]
[ApiController]
public class RoomTransfersController : ControllerBase
{
    private static readonly List<RoomTransfer> _roomTransfers = new List<RoomTransfer>();

    // GET: api/roomtransfers
    [HttpGet]
    public ActionResult<IEnumerable<RoomTransfer>> GetRoomTransfers()
    {
        return _roomTransfers;
    }

    // GET: api/roomtransfers/1
    [HttpGet("{id}")]
    public ActionResult<RoomTransfer> GetRoomTransfer(int id)
    {
        var roomTransfer = _roomTransfers.FirstOrDefault(rt => rt.Id == id);
        if (roomTransfer == null)
        {
            return NotFound();
        }
        return roomTransfer;
    }

    // POST: api/roomtransfers
    [HttpPost]
    public ActionResult<RoomTransfer> CreateRoomTransfer([FromBody] RoomTransfer roomTransfer)
    {
        roomTransfer.Id = _roomTransfers.Any() ? _roomTransfers.Max(rt => rt.Id) + 1 : 1;
        _roomTransfers.Add(roomTransfer);
        return CreatedAtAction(nameof(GetRoomTransfer), new { id = roomTransfer.Id }, roomTransfer);
    }

    // PUT: api/roomtransfers/1
    [HttpPut("{id}")]
    public IActionResult UpdateRoomTransfer(int id, [FromBody] RoomTransfer updatedRoomTransfer)
    {
        var roomTransfer = _roomTransfers.FirstOrDefault(rt => rt.Id == id);
        if (roomTransfer == null)
        {
            return NotFound();
        }

        roomTransfer.Name = updatedRoomTransfer.Name;
        roomTransfer.CurrentRoomNumber = updatedRoomTransfer.CurrentRoomNumber;
        roomTransfer.NewRoomNumber = updatedRoomTransfer.NewRoomNumber;
        roomTransfer.ReasonForMove = updatedRoomTransfer.ReasonForMove;
        roomTransfer.FromDate = updatedRoomTransfer.FromDate;
        roomTransfer.ToDate = updatedRoomTransfer.ToDate;

        return NoContent();
    }

    // DELETE: api/roomtransfers/1
    [HttpDelete("{id}")]
    public IActionResult DeleteRoomTransfer(int id)
    {
        var roomTransfer = _roomTransfers.FirstOrDefault(rt => rt.Id == id);
        if (roomTransfer == null)
        {
            return NotFound();
        }

        _roomTransfers.Remove(roomTransfer);
        return NoContent();
    }
}
