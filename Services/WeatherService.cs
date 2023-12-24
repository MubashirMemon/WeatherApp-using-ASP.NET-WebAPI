using Flurl.Http;
using System.Linq.Expressions;

using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class WeatherService
    {
        public async Task<ResponseModel> GetWeatherData(string location)
        {
            string weatherApiUrl = AppConstants.WeatherApiUrl;
            string weatherApiKey = AppConstants.WeatherApiKey;
            string apiUrl = $"{weatherApiUrl}?access_key={weatherApiKey}&query=42.3605, -71.059";
            try
            {
                var response = await apiUrl.GetAsync();
                if (response.StatusCode == 200)
                {
                    var responseData = await response.GetJsonAsync<WeatherModel>();
                    return ResponseModel.Success(responseData);
                }
                return ResponseModel.Error(response.ResponseMessage.ToString());
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ResponseModel>();
                return ResponseModel.Error(errorResponse);
            }
              
            } 
            }
        }
    
   