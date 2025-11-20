using System.ComponentModel.DataAnnotations;

namespace MeetingManagementApplication.Dtos.Meeting.Command;

public class CreateMeetingCommandDto
{
    [Required(ErrorMessage = "عنوان الزامی می باشد")]
    public string Title { get; set; } = null!;

    [Required(ErrorMessage = "توضیحات الزامی می باشد")]
    public string Description { get; set; } = null!;

    [Required(ErrorMessage = "تاریخ جلسه الزامی می باشد")]
    public DateTime MeetingDate { get; set; }

    [Required(ErrorMessage = "لیست مصوبات الزامی می باشد")]
    [MinLength(1, ErrorMessage = "حداقل یک مصوبه باید ثبت شود")]
    public List<ResolutionInputDto> Resolutions { get; set; } = new();


}