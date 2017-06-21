
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RAML.Api.Core;
using Raml.Common;
using Multrees.WebAPI.Models;

namespace Multrees.WebAPI
{
    /// <summary>
    /// Collection of all clients ... [TODO]
    /// </summary>
    public partial class Clients
    {
        private readonly api.ramlClient proxy;

        internal Clients(api.ramlClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// Collection of all clients ... [TODO]. Retrieve all clients. - Clients
		/// </summary>
        public virtual async Task<Models.ClientsGetResponse> Get()
        {

            var url = "clients";

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
					
			}

            return new Models.ClientsGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };

        }

        /// <summary>
		/// Collection of all clients ... [TODO]. Retrieve all clients. - Clients
		/// </summary>
		/// <param name="request">ApiRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<Models.ClientsGetResponse> Get(ApiRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "clients";

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
				
            }
            return new Models.ClientsGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };
        }


        /// <summary>
		/// A client ... [TODO]. Retrieve a client. - Client
		/// </summary>
		/// <param name="client"></param>
        public virtual async Task<Models.ClientsGetByClientResponse> GetByClient(string client)
        {

            var url = "clients/{client}";
            url = url.Replace("{client}", client.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
					
			}

            return new Models.ClientsGetByClientResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };

        }

        /// <summary>
		/// A client ... [TODO]. Retrieve a client. - Client
		/// </summary>
		/// <param name="request">Models.ClientsGetByClientRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<Models.ClientsGetByClientResponse> GetByClient(Models.ClientsGetByClientRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "clients/{client}";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Client == null)
				throw new InvalidOperationException("Uri Parameter Client cannot be null");

            url = url.Replace("{client}", request.UriParameters.Client.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
				
            }
            return new Models.ClientsGetByClientResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };
        }

    }

    /// <summary>
    /// Collection of all accounts ... [TODO]
    /// </summary>
    public partial class Accounts
    {
        private readonly api.ramlClient proxy;

        internal Accounts(api.ramlClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// Collection of all accounts ... [TODO]. Retrieve all accounts. - Accounts
		/// </summary>
        public virtual async Task<Models.AccountsGetResponse> Get()
        {

            var url = "accounts";

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
					
			}

            return new Models.AccountsGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };

        }

        /// <summary>
		/// Collection of all accounts ... [TODO]. Retrieve all accounts. - Accounts
		/// </summary>
		/// <param name="request">ApiRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<Models.AccountsGetResponse> Get(ApiRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "accounts";

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
				
            }
            return new Models.AccountsGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };
        }


        /// <summary>
		/// An account ... [TODO]. Retrieve an account. - Account
		/// </summary>
		/// <param name="account"></param>
        public virtual async Task<Models.AccountsGetByAccountResponse> GetByAccount(string account)
        {

            var url = "accounts/{account}";
            url = url.Replace("{account}", account.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
					
			}

            return new Models.AccountsGetByAccountResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };

        }

        /// <summary>
		/// An account ... [TODO]. Retrieve an account. - Account
		/// </summary>
		/// <param name="request">Models.AccountsGetByAccountRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<Models.AccountsGetByAccountResponse> GetByAccount(Models.AccountsGetByAccountRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "accounts/{account}";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Account == null)
				throw new InvalidOperationException("Uri Parameter Account cannot be null");

            url = url.Replace("{account}", request.UriParameters.Account.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
				
            }
            return new Models.AccountsGetByAccountResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };
        }

    }

    /// <summary>
    /// Collection of all beneficiaries ... [TODO]
    /// </summary>
    public partial class Beneficiaries
    {
        private readonly api.ramlClient proxy;

        internal Beneficiaries(api.ramlClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// Collection of all beneficiaries ... [TODO]. Retrieve all beneficiaries. - Beneficiaries
		/// </summary>
        public virtual async Task<Models.BeneficiariesGetResponse> Get()
        {

            var url = "beneficiaries";

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
					
			}

            return new Models.BeneficiariesGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };

        }

        /// <summary>
		/// Collection of all beneficiaries ... [TODO]. Retrieve all beneficiaries. - Beneficiaries
		/// </summary>
		/// <param name="request">ApiRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<Models.BeneficiariesGetResponse> Get(ApiRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "beneficiaries";

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
				
            }
            return new Models.BeneficiariesGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };
        }


        /// <summary>
		/// A beneficiary ... [TODO]. Retrieve a beneficiary. - Beneficiary
		/// </summary>
		/// <param name="beneficiary"></param>
        public virtual async Task<Models.BeneficiariesGetByBeneficiaryResponse> GetByBeneficiary(string beneficiary)
        {

            var url = "beneficiaries/{beneficiary}";
            url = url.Replace("{beneficiary}", beneficiary.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
					
			}

            return new Models.BeneficiariesGetByBeneficiaryResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };

        }

        /// <summary>
		/// A beneficiary ... [TODO]. Retrieve a beneficiary. - Beneficiary
		/// </summary>
		/// <param name="request">Models.BeneficiariesGetByBeneficiaryRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<Models.BeneficiariesGetByBeneficiaryResponse> GetByBeneficiary(Models.BeneficiariesGetByBeneficiaryRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "beneficiaries/{beneficiary}";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Beneficiary == null)
				throw new InvalidOperationException("Uri Parameter Beneficiary cannot be null");

            url = url.Replace("{beneficiary}", request.UriParameters.Beneficiary.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
				
            }
            return new Models.BeneficiariesGetByBeneficiaryResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };
        }

    }

    public partial class ClassificationsClassification
    {
        private readonly api.ramlClient proxy;

        internal ClassificationsClassification(api.ramlClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// /classifications/{classification}
		/// </summary>
		/// <param name="classification"></param>
		/// <param name="holding"></param>
        public virtual async Task<Models.ClassificationsClassificationGetResponse> Get(string classification, string holding)
        {

            var url = "holdings/{holding}/classifications/{classification}";
            url = url.Replace("{classification}", classification.ToString());
            url = url.Replace("{holding}", holding.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
					
			}

            return new Models.ClassificationsClassificationGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };

        }

        /// <summary>
		/// /classifications/{classification}
		/// </summary>
		/// <param name="request">Models.ClassificationsClassificationGetRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<Models.ClassificationsClassificationGetResponse> Get(Models.ClassificationsClassificationGetRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "holdings/{holding}/classifications/{classification}";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Classification == null)
				throw new InvalidOperationException("Uri Parameter Classification cannot be null");

            url = url.Replace("{classification}", request.UriParameters.Classification.ToString());

			if(request.UriParameters.Holding == null)
				throw new InvalidOperationException("Uri Parameter Holding cannot be null");

            url = url.Replace("{holding}", request.UriParameters.Holding.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
				
            }
            return new Models.ClassificationsClassificationGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };
        }

    }

    public partial class AccountsAccount
    {
        private readonly api.ramlClient proxy;

        internal AccountsAccount(api.ramlClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// /accounts/{account}
		/// </summary>
		/// <param name="account"></param>
		/// <param name="holding"></param>
        public virtual async Task<Models.AccountsAccountGetResponse> Get(string account, string holding)
        {

            var url = "holdings/{holding}/accounts/{account}";
            url = url.Replace("{account}", account.ToString());
            url = url.Replace("{holding}", holding.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
					
			}

            return new Models.AccountsAccountGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };

        }

        /// <summary>
		/// /accounts/{account}
		/// </summary>
		/// <param name="request">Models.AccountsAccountGetRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<Models.AccountsAccountGetResponse> Get(Models.AccountsAccountGetRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "holdings/{holding}/accounts/{account}";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Account == null)
				throw new InvalidOperationException("Uri Parameter Account cannot be null");

            url = url.Replace("{account}", request.UriParameters.Account.ToString());

			if(request.UriParameters.Holding == null)
				throw new InvalidOperationException("Uri Parameter Holding cannot be null");

            url = url.Replace("{holding}", request.UriParameters.Holding.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
				
            }
            return new Models.AccountsAccountGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };
        }

    }

    /// <summary>
    /// Collection of all holdings.
    /// </summary>
    public partial class Holdings
    {
        private readonly api.ramlClient proxy;

        internal Holdings(api.ramlClient proxy)
        {
            this.proxy = proxy;
        }

        public virtual ClassificationsClassification ClassificationsClassification
        {
            get { return new ClassificationsClassification(proxy); }
        }

        public virtual AccountsAccount AccountsAccount
        {
            get { return new AccountsAccount(proxy); }
        }


        /// <summary>
		/// Collection of all holdings.. Retrieve all holdings. - Holdings
		/// </summary>
		/// <param name="getholdingsquery">query properties</param>
        public virtual async Task<Models.HoldingsGetResponse> Get(Models.GetHoldingsQuery getholdingsquery)
        {

            var url = "holdings";
            if(getholdingsquery != null)
            {
                url += "?";
                if(getholdingsquery.ExtractDate != null)
					url += "&extractDate=" + getholdingsquery.ExtractDate;
            }

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
					
			}

            return new Models.HoldingsGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };

        }

        /// <summary>
		/// Collection of all holdings.. Retrieve all holdings. - Holdings
		/// </summary>
		/// <param name="request">Models.HoldingsGetRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<Models.HoldingsGetResponse> Get(Models.HoldingsGetRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "holdings";
            if(request.Query != null)
            {
                url += "?";
                if(request.Query.ExtractDate != null)
                    url += "&extractDate=" + request.Query.ExtractDate;
            }

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
				
            }
            return new Models.HoldingsGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };
        }


        /// <summary>
		/// A holding ... [TODO] - Holding
		/// </summary>
		/// <param name="holding"></param>
        public virtual async Task<Models.HoldingsGetByHoldingResponse> GetByHolding(string holding)
        {

            var url = "holdings/{holding}";
            url = url.Replace("{holding}", holding.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
					
			}

            return new Models.HoldingsGetByHoldingResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };

        }

        /// <summary>
		/// A holding ... [TODO] - Holding
		/// </summary>
		/// <param name="request">Models.HoldingsGetByHoldingRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<Models.HoldingsGetByHoldingResponse> GetByHolding(Models.HoldingsGetByHoldingRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "holdings/{holding}";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Holding == null)
				throw new InvalidOperationException("Uri Parameter Holding cannot be null");

            url = url.Replace("{holding}", request.UriParameters.Holding.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
				
            }
            return new Models.HoldingsGetByHoldingResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };
        }

    }

    /// <summary>
    /// Collection of all payments.
    /// </summary>
    public partial class Payments
    {
        private readonly api.ramlClient proxy;

        internal Payments(api.ramlClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// Collection of all payments.. Retrieve all payments. - Payments
		/// </summary>
        public virtual async Task<Models.PaymentsGetResponse> Get()
        {

            var url = "payments";

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
					
			}

            return new Models.PaymentsGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };

        }

        /// <summary>
		/// Collection of all payments.. Retrieve all payments. - Payments
		/// </summary>
		/// <param name="request">ApiRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<Models.PaymentsGetResponse> Get(ApiRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "payments";

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
				
            }
            return new Models.PaymentsGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };
        }


        /// <summary>
		/// A single payment ... [TODO]. Retrieve a payment. - /{payment}
		/// </summary>
		/// <param name="payment"></param>
        public virtual async Task<Models.PaymentsGetByPaymentResponse> GetByPayment(string payment)
        {

            var url = "payments/{payment}";
            url = url.Replace("{payment}", payment.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
					
			}

            return new Models.PaymentsGetByPaymentResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };

        }

        /// <summary>
		/// A single payment ... [TODO]. Retrieve a payment. - /{payment}
		/// </summary>
		/// <param name="request">Models.PaymentsGetByPaymentRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<Models.PaymentsGetByPaymentResponse> GetByPayment(Models.PaymentsGetByPaymentRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "payments/{payment}";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Payment == null)
				throw new InvalidOperationException("Uri Parameter Payment cannot be null");

            url = url.Replace("{payment}", request.UriParameters.Payment.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
				
            }
            return new Models.PaymentsGetByPaymentResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };
        }

    }

    /// <summary>
    /// Collection of all trades.
    /// </summary>
    public partial class Trades
    {
        private readonly api.ramlClient proxy;

        internal Trades(api.ramlClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// Collection of all trades.. Retrieve all trades. - Trades
		/// </summary>
        public virtual async Task<Models.TradesGetResponse> Get()
        {

            var url = "trades";

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
					
			}

            return new Models.TradesGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };

        }

        /// <summary>
		/// Collection of all trades.. Retrieve all trades. - Trades
		/// </summary>
		/// <param name="request">ApiRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<Models.TradesGetResponse> Get(ApiRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "trades";

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
				
            }
            return new Models.TradesGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };
        }


        /// <summary>
		/// A trade ... [TODO]. Retrieve a single trade. - Trade
		/// </summary>
		/// <param name="trade"></param>
        public virtual async Task<Models.TradesGetByTradeResponse> GetByTrade(string trade)
        {

            var url = "trades/{trade}";
            url = url.Replace("{trade}", trade.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
					
			}

            return new Models.TradesGetByTradeResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };

        }

        /// <summary>
		/// A trade ... [TODO]. Retrieve a single trade. - Trade
		/// </summary>
		/// <param name="request">Models.TradesGetByTradeRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<Models.TradesGetByTradeResponse> GetByTrade(Models.TradesGetByTradeRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "trades/{trade}";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Trade == null)
				throw new InvalidOperationException("Uri Parameter Trade cannot be null");

            url = url.Replace("{trade}", request.UriParameters.Trade.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("", response.Content);
				}
				
            }
            return new Models.TradesGetByTradeResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("", response.Content), true)
                                            };
        }

    }

    /// <summary>
    /// Collection of all users.
    /// </summary>
    public partial class Users
    {
        private readonly api.ramlClient proxy;

        internal Users(api.ramlClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// Collection of all users.. Retrieve all users. - Users
		/// </summary>
        public virtual async Task<ApiResponse> Get()
        {

            var url = "users";

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);

            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// Collection of all users.. Retrieve all users. - Users
		/// </summary>
		/// <param name="request">ApiRequest</param>
        public virtual async Task<ApiResponse> Get(ApiRequest request)
        {

            var url = "users";

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }


        /// <summary>
		/// A user ... [TODO]. Retieve a user. - User
		/// </summary>
		/// <param name="user"></param>
        public virtual async Task<ApiResponse> GetByUser(string user)
        {

            var url = "users/{user}";
            url = url.Replace("{user}", user.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);

            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// A user ... [TODO]. Retieve a user. - User
		/// </summary>
		/// <param name="request">Models.UsersGetByUserRequest</param>
        public virtual async Task<ApiResponse> GetByUser(Models.UsersGetByUserRequest request)
        {

            var url = "users/{user}";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.User == null)
				throw new InvalidOperationException("Uri Parameter User cannot be null");

            url = url.Replace("{user}", request.UriParameters.User.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }

    }

    /// <summary>
    /// Main class for grouping root resources. Nested resources are defined as properties. The constructor can optionally receive an URL and HttpClient instance to override the default ones.
    /// </summary>
    public partial class api.ramlClient
    {

		public SchemaValidationSettings SchemaValidation { get; private set; } 

        protected readonly HttpClient client;
        public const string BaseUri = "https://api.multrees.com/v{version}/{fi}/";

        internal HttpClient Client { get { return client; } }




        public api.ramlClient(string endpointUrl)
        {
            SchemaValidation = new SchemaValidationSettings
			{
				Enabled = true,
				RaiseExceptions = true
			};

			if(string.IsNullOrWhiteSpace(endpointUrl))
                throw new ArgumentException("You must specify the endpoint URL", "endpointUrl");

			if (endpointUrl.Contains("{"))
			{
				var regex = new Regex(@"\{([^\}]+)\}");
				var matches = regex.Matches(endpointUrl);
				var parameters = new List<string>();
				foreach (Match match in matches)
				{
					parameters.Add(match.Groups[1].Value);
				}
				throw new InvalidOperationException("Please replace parameter/s " + string.Join(", ", parameters) + " in the URL before passing it to the constructor ");
			}

            client = new HttpClient {BaseAddress = new Uri(endpointUrl)};
        }

        public api.ramlClient(HttpClient httpClient)
        {
            if(httpClient.BaseAddress == null)
                throw new InvalidOperationException("You must set the BaseAddress property of the HttpClient instance");

            client = httpClient;

			SchemaValidation = new SchemaValidationSettings
			{
				Enabled = true,
				RaiseExceptions = true
			};
        }

        

        public virtual Clients Clients
        {
            get { return new Clients(this); }
        }
                

        public virtual Accounts Accounts
        {
            get { return new Accounts(this); }
        }
                

        public virtual Beneficiaries Beneficiaries
        {
            get { return new Beneficiaries(this); }
        }
                

        public virtual Holdings Holdings
        {
            get { return new Holdings(this); }
        }
                

        public virtual Payments Payments
        {
            get { return new Payments(this); }
        }
                

        public virtual Trades Trades
        {
            get { return new Trades(this); }
        }
                

        public virtual Users Users
        {
            get { return new Users(this); }
        }
                


		public void AddDefaultRequestHeader(string name, string value)
		{
			client.DefaultRequestHeaders.Add(name, value);
		}

		public void AddDefaultRequestHeader(string name, IEnumerable<string> values)
		{
			client.DefaultRequestHeaders.Add(name, values);
		}


    }

} // end namespace









namespace Multrees.WebAPI.Models
{
    /// <summary>
    /// Request object for method GetByClient of class Clients
    /// </summary>
    public partial class ClientsGetByClientRequest : ApiRequest
    {
        public ClientsGetByClientRequest(ClientsClientUriParameters UriParameters)
        {
        }


    } // end class

    /// <summary>
    /// Request object for method GetByAccount of class Accounts
    /// </summary>
    public partial class AccountsGetByAccountRequest : ApiRequest
    {
        public AccountsGetByAccountRequest(AccountsAccountUriParameters UriParameters)
        {
        }


    } // end class

    /// <summary>
    /// Request object for method GetByBeneficiary of class Beneficiaries
    /// </summary>
    public partial class BeneficiariesGetByBeneficiaryRequest : ApiRequest
    {
        public BeneficiariesGetByBeneficiaryRequest(BeneficiariesBeneficiaryUriParameters UriParameters)
        {
        }


    } // end class

    /// <summary>
    /// Request object for method Get of class ClassificationsClassification
    /// </summary>
    public partial class ClassificationsClassificationGetRequest : ApiRequest
    {
        public ClassificationsClassificationGetRequest(HoldingsHoldingClassificationsClassificationUriParameters UriParameters)
        {
        }


    } // end class

    /// <summary>
    /// Request object for method Get of class AccountsAccount
    /// </summary>
    public partial class AccountsAccountGetRequest : ApiRequest
    {
        public AccountsAccountGetRequest(HoldingsHoldingAccountsAccountUriParameters UriParameters)
        {
        }


    } // end class

    /// <summary>
    /// Request object for method Get of class Holdings
    /// </summary>
    public partial class HoldingsGetRequest : ApiRequest
    {
        public HoldingsGetRequest(GetHoldingsQuery Query = null)
        {
        }


    } // end class

    /// <summary>
    /// Request object for method GetByHolding of class Holdings
    /// </summary>
    public partial class HoldingsGetByHoldingRequest : ApiRequest
    {
        public HoldingsGetByHoldingRequest(HoldingsHoldingUriParameters UriParameters)
        {
        }


    } // end class

    /// <summary>
    /// Request object for method GetByPayment of class Payments
    /// </summary>
    public partial class PaymentsGetByPaymentRequest : ApiRequest
    {
        public PaymentsGetByPaymentRequest(PaymentsPaymentUriParameters UriParameters)
        {
        }


    } // end class

    /// <summary>
    /// Request object for method GetByTrade of class Trades
    /// </summary>
    public partial class TradesGetByTradeRequest : ApiRequest
    {
        public TradesGetByTradeRequest(TradesTradeUriParameters UriParameters)
        {
        }


    } // end class

    /// <summary>
    /// Request object for method GetByUser of class Users
    /// </summary>
    public partial class UsersGetByUserRequest : ApiRequest
    {
        public UsersGetByUserRequest(UsersUserUriParameters UriParameters)
        {
        }


    } // end class

    /// <summary>
    /// Response object for method Get of class Clients
    /// </summary>

    public partial class ClientsGetResponse : ApiResponse
    {


	    private IList<Client> typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public IList<Client> Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (IList<Client>)new XmlSerializer(typeof(IList<Client>)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<IList<Client>>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<IList<Client>>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method GetByClient of class Clients
    /// </summary>

    public partial class ClientsGetByClientResponse : ApiResponse
    {


	    private Client typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public Client Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (Client)new XmlSerializer(typeof(Client)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<Client>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<Client>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method Get of class Accounts
    /// </summary>

    public partial class AccountsGetResponse : ApiResponse
    {


	    private IList<Account> typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public IList<Account> Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (IList<Account>)new XmlSerializer(typeof(IList<Account>)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<IList<Account>>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<IList<Account>>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method GetByAccount of class Accounts
    /// </summary>

    public partial class AccountsGetByAccountResponse : ApiResponse
    {


	    private Account typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public Account Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (Account)new XmlSerializer(typeof(Account)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<Account>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<Account>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method Get of class Beneficiaries
    /// </summary>

    public partial class BeneficiariesGetResponse : ApiResponse
    {


	    private IList<Beneficiary> typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public IList<Beneficiary> Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (IList<Beneficiary>)new XmlSerializer(typeof(IList<Beneficiary>)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<IList<Beneficiary>>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<IList<Beneficiary>>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method GetByBeneficiary of class Beneficiaries
    /// </summary>

    public partial class BeneficiariesGetByBeneficiaryResponse : ApiResponse
    {


	    private Beneficiary typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public Beneficiary Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (Beneficiary)new XmlSerializer(typeof(Beneficiary)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<Beneficiary>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<Beneficiary>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method Get of class ClassificationsClassification
    /// </summary>

    public partial class ClassificationsClassificationGetResponse : ApiResponse
    {


	    private IList<Holding> typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public IList<Holding> Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (IList<Holding>)new XmlSerializer(typeof(IList<Holding>)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<IList<Holding>>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<IList<Holding>>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method Get of class AccountsAccount
    /// </summary>

    public partial class AccountsAccountGetResponse : ApiResponse
    {


	    private IList<Holding> typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public IList<Holding> Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (IList<Holding>)new XmlSerializer(typeof(IList<Holding>)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<IList<Holding>>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<IList<Holding>>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method Get of class Holdings
    /// </summary>

    public partial class HoldingsGetResponse : ApiResponse
    {


	    private IList<Holding> typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public IList<Holding> Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (IList<Holding>)new XmlSerializer(typeof(IList<Holding>)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<IList<Holding>>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<IList<Holding>>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method GetByHolding of class Holdings
    /// </summary>

    public partial class HoldingsGetByHoldingResponse : ApiResponse
    {


	    private Holding typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public Holding Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (Holding)new XmlSerializer(typeof(Holding)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<Holding>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<Holding>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method Get of class Payments
    /// </summary>

    public partial class PaymentsGetResponse : ApiResponse
    {


	    private IList<Payment> typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public IList<Payment> Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (IList<Payment>)new XmlSerializer(typeof(IList<Payment>)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<IList<Payment>>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<IList<Payment>>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method GetByPayment of class Payments
    /// </summary>

    public partial class PaymentsGetByPaymentResponse : ApiResponse
    {


	    private Payment typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public Payment Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (Payment)new XmlSerializer(typeof(Payment)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<Payment>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<Payment>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method Get of class Trades
    /// </summary>

    public partial class TradesGetResponse : ApiResponse
    {


	    private IList<Trade> typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public IList<Trade> Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (IList<Trade>)new XmlSerializer(typeof(IList<Trade>)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<IList<Trade>>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<IList<Trade>>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method GetByTrade of class Trades
    /// </summary>

    public partial class TradesGetByTradeResponse : ApiResponse
    {


	    private Trade typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public Trade Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (Trade)new XmlSerializer(typeof(Trade)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<Trade>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<Trade>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class


} // end Models namespace
