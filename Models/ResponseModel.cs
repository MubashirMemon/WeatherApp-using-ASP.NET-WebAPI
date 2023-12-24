using WeatherApp.Models;

namespace WeatherApp.Models
{
    public class ResponseModel
    {
        public bool IsSuccess { get; set; }
        public String? Message { get; set; }
        public dynamic? JsonData { get; set; }
    
    public static ResponseModel Success(dynamic jsonData)
    {
        return new ResponseModel
        {
            JsonData = jsonData,
            Message = null,
            IsSuccess = true
        };
    }
    public static ResponseModel Error(string errorMessage)
    {
        return new ResponseModel
        {
            JsonData = null,
            Message = errorMessage,
            IsSuccess = false
                };
              }

        internal static ResponseModel Error(ResponseModel errorResponse)
        {
            throw new NotImplementedException();
        }
    }
        }