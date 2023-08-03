namespace MambuStudy.Application.ViewModel.Response
{
    public class ErrorResponse
    {
        public List<RestError> Errors { get; set; }
    }

    public class RestError
    {
        public int ErroCode { get; set; }
        public string ErrorReason { get; set; }
        public string ErrorSource { get; set; }
    }
}
