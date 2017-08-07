﻿using NeverBounce.Models;
using NeverBounce.Utilities;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace NeverBounce.Services
{
    public class JobsService
    {
		protected string ApiKey;

		protected string Host;

        public JobsService(string ApiKey, string Host = null)
		{
			this.ApiKey = ApiKey;

			// Accept debug host
			if (Host != null)
				this.Host = Host;
		}

		/// <summary>
        /// This method calls the search job end points.
        /// See: "https://api.neverbounce.com/v4/jobs/search"
		/// </summary>
		/// <param name="model">JobSearchRequestModel</param>
		/// <returns>JobSearchResponseModel</returns>
		public async Task<JobSearchResponseModel> Search(JobSearchRequestModel model)
        {
            NeverBounceHttpClient client = new NeverBounceHttpClient(ApiKey, Host);
            var result = await client.MakeRequest("GET", "/jobs/search", model);
            return JsonConvert.DeserializeObject<JobSearchResponseModel>(result.json.ToString());
        }

		/// <summary>
		/// This method calls the create job end point.
		/// See: "https://api.neverbounce.com/v4/jobs/create"
		/// </summary>
		/// <param name="model">JobCreateRequestModel</param>
		/// <returns>JobCreateResponseModel</returns>
		public async Task<JobCreateResponseModel> Create(JobCreateRequestModel model)
        {
			NeverBounceHttpClient client = new NeverBounceHttpClient(ApiKey, Host);
            var result = await client.MakeRequest("POST", "/jobs/create",  model);
            return JsonConvert.DeserializeObject<JobCreateResponseModel>(result.json.ToString());
        }

		/// <summary>
		/// This method calls the parse job end point
		/// See: "https://api.neverbounce.com/v4/jobs/parse"
		/// </summary>
		/// <param name="model">JobParseRequestModel</param>
		/// <returns>JobParseResponseModel</returns>
		public async Task<JobParseResponseModel> Parse(JobParseRequestModel model)
        {
			NeverBounceHttpClient client = new NeverBounceHttpClient(ApiKey, Host);
			var result = await client.MakeRequest("POST", "/jobs/parse", model);
			return JsonConvert.DeserializeObject<JobParseResponseModel>(result.json.ToString());
        }

		/// <summary>
		/// This method calls the start job end point
		/// See: "https://api.neverbounce.com/v4/jobs/start"
		/// </summary>
		/// <param name="model">JobStartRequestModel</param>
		/// <returns>JobStartResponseModel</returns>
		public async Task<JobStartResponseModel> Start(JobStartRequestModel model)
        {
			NeverBounceHttpClient client = new NeverBounceHttpClient(ApiKey, Host);
			var result = await client.MakeRequest("POST", "/jobs/start", model);
			return JsonConvert.DeserializeObject<JobStartResponseModel>(result.json.ToString());
        }

		/// <summary>
		/// This method calls the job status endpoint
		/// See: "https://api.neverbounce.com/v4/jobs/status"
		/// </summary>
		/// <param name="model">JobStatusRequestModel</param>
		/// <returns>JobStatusResponseModel</returns>
		public async Task<JobStatusResponseModel> Status(JobStatusRequestModel model)
        {
			NeverBounceHttpClient client = new NeverBounceHttpClient(ApiKey, Host);
			var result = await client.MakeRequest("GET", "/jobs/status", model);
            return JsonConvert.DeserializeObject<JobStatusResponseModel>(result.json.ToString());
        }

		/// <summary>
		/// This method calls the job results endpoint
		/// See: "https://api.neverbounce.com/v4/jobs/results"
		/// </summary>
		/// <param name="model">JobResultsRequestModel</param>
		/// <returns>JobResultsResponseModel</returns>
		public async Task<JobResultsResponseModel> Results(JobResultsRequestModel model)
        {
			NeverBounceHttpClient client = new NeverBounceHttpClient(ApiKey, Host);
			var result = await client.MakeRequest("GET", "/jobs/results", model);
            return JsonConvert.DeserializeObject<JobResultsResponseModel>(result.json.ToString());
        }

		/// <summary>
        /// This method calls the job download endpoint; this endpoint returns the
        /// CSV data for the job
		/// See: "https://api.neverbounce.com/v4/jobs/download"
		/// </summary>
		/// <param name="model">JobDownloadRequestModel</param>
		/// <returns>string</returns>
		public async Task<String> Download(JobDownloadRequestModel model)
		{
			NeverBounceHttpClient client = new NeverBounceHttpClient(ApiKey, Host);
			var result = await client.MakeRequest("GET", "/jobs/download", model);
			return result.plaintext;
		}

		/// <summary>
		/// This method calls the job delete endpoint
		/// See: "https://api.neverbounce.com/v4/jobs/delete"
		/// </summary>
		/// <param name="model">JobDeleteRequestModel</param>
		/// <returns>JobResultsResponseModel</returns>
		public async Task<JobDeleteResponseModel> Delete(JobDeleteRequestModel model)
		{
			NeverBounceHttpClient client = new NeverBounceHttpClient(ApiKey, Host);
			var result = await client.MakeRequest("GET", "/jobs/delete", model);
			return JsonConvert.DeserializeObject<JobDeleteResponseModel>(result.json.ToString());
		}
    }
}
