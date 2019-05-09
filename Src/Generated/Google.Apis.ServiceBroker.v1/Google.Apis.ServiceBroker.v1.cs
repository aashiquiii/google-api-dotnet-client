// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by google-apis-code-generator 1.5.1
//     C# generator version: 1.40.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \brief
 *   Service Broker API Version v1
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://cloud.google.com/kubernetes-engine/docs/concepts/add-on/service-broker'>Service Broker API</a>
 *      <tr><th>API Version<td>v1
 *      <tr><th>API Rev<td>20190506 (1586)
 *      <tr><th>API Docs
 *          <td><a href='https://cloud.google.com/kubernetes-engine/docs/concepts/add-on/service-broker'>
 *              https://cloud.google.com/kubernetes-engine/docs/concepts/add-on/service-broker</a>
 *      <tr><th>Discovery Name<td>servicebroker
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using Service Broker API can be found at
 * <a href='https://cloud.google.com/kubernetes-engine/docs/concepts/add-on/service-broker'>https://cloud.google.com/kubernetes-engine/docs/concepts/add-on/service-broker</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.ServiceBroker.v1
{
    /// <summary>The ServiceBroker Service.</summary>
    public class ServiceBrokerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ServiceBrokerService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ServiceBrokerService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            v1 = new V1Resource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "servicebroker"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            get { return BaseUriOverride ?? "https://servicebroker.googleapis.com/"; }
        #else
            get { return "https://servicebroker.googleapis.com/"; }
        #endif
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return ""; }
        }

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri
        {
            get { return "https://servicebroker.googleapis.com/batch"; }
        }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath
        {
            get { return "batch"; }
        }
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Service Broker API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Service Broker API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

        }



        private readonly V1Resource v1;

        /// <summary>Gets the V1 resource.</summary>
        public virtual V1Resource V1
        {
            get { return v1; }
        }
    }

    ///<summary>A base abstract class for ServiceBroker requests.</summary>
    public abstract class ServiceBrokerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new ServiceBrokerBaseServiceRequest instance.</summary>
        protected ServiceBrokerBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1,
            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,
            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes ServiceBroker parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "$.xgafv", new Google.Apis.Discovery.Parameter
                {
                    Name = "$.xgafv",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "access_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "access_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "callback", new Google.Apis.Discovery.Parameter
                {
                    Name = "callback",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "uploadType", new Google.Apis.Discovery.Parameter
                {
                    Name = "uploadType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "upload_protocol", new Google.Apis.Discovery.Parameter
                {
                    Name = "upload_protocol",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "v1" collection of methods.</summary>
    public class V1Resource
    {
        private const string Resource = "v1";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public V1Resource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Gets the access control policy for a resource. Returns an empty policy if the resource exists and
        /// does not have a policy set.</summary>
        /// <param name="resource">REQUIRED: The resource for which the policy is being requested. See the operation
        /// documentation for the appropriate value for this field.</param>
        public virtual GetIamPolicyRequest GetIamPolicy(string resource)
        {
            return new GetIamPolicyRequest(service, resource);
        }

        /// <summary>Gets the access control policy for a resource. Returns an empty policy if the resource exists and
        /// does not have a policy set.</summary>
        public class GetIamPolicyRequest : ServiceBrokerBaseServiceRequest<Google.Apis.ServiceBroker.v1.Data.GoogleIamV1Policy>
        {
            /// <summary>Constructs a new GetIamPolicy request.</summary>
            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource)
                : base(service)
            {
                Resource = resource;
                InitParameters();
            }


            /// <summary>REQUIRED: The resource for which the policy is being requested. See the operation documentation
            /// for the appropriate value for this field.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "getIamPolicy"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "GET"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "v1/{+resource}:getIamPolicy"; }
            }

            /// <summary>Initializes GetIamPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "resource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resource",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^.+$",
                    });
            }

        }

        /// <summary>Sets the access control policy on the specified resource. Replaces any existing policy.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">REQUIRED: The resource for which the policy is being specified. See the operation
        /// documentation for the appropriate value for this field.</param>
        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.ServiceBroker.v1.Data.GoogleIamV1SetIamPolicyRequest body, string resource)
        {
            return new SetIamPolicyRequest(service, body, resource);
        }

        /// <summary>Sets the access control policy on the specified resource. Replaces any existing policy.</summary>
        public class SetIamPolicyRequest : ServiceBrokerBaseServiceRequest<Google.Apis.ServiceBroker.v1.Data.GoogleIamV1Policy>
        {
            /// <summary>Constructs a new SetIamPolicy request.</summary>
            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ServiceBroker.v1.Data.GoogleIamV1SetIamPolicyRequest body, string resource)
                : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }


            /// <summary>REQUIRED: The resource for which the policy is being specified. See the operation documentation
            /// for the appropriate value for this field.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ServiceBroker.v1.Data.GoogleIamV1SetIamPolicyRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() { return Body; }

            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "setIamPolicy"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "POST"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "v1/{+resource}:setIamPolicy"; }
            }

            /// <summary>Initializes SetIamPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "resource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resource",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^.+$",
                    });
            }

        }

        /// <summary>Returns permissions that a caller has on the specified resource. If the resource does not exist,
        /// this will return an empty set of permissions, not a NOT_FOUND error.
        ///
        /// Note: This operation is designed to be used for building permission-aware UIs and command-line tools, not
        /// for authorization checking. This operation may "fail open" without warning.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">REQUIRED: The resource for which the policy detail is being requested. See the operation
        /// documentation for the appropriate value for this field.</param>
        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.ServiceBroker.v1.Data.GoogleIamV1TestIamPermissionsRequest body, string resource)
        {
            return new TestIamPermissionsRequest(service, body, resource);
        }

        /// <summary>Returns permissions that a caller has on the specified resource. If the resource does not exist,
        /// this will return an empty set of permissions, not a NOT_FOUND error.
        ///
        /// Note: This operation is designed to be used for building permission-aware UIs and command-line tools, not
        /// for authorization checking. This operation may "fail open" without warning.</summary>
        public class TestIamPermissionsRequest : ServiceBrokerBaseServiceRequest<Google.Apis.ServiceBroker.v1.Data.GoogleIamV1TestIamPermissionsResponse>
        {
            /// <summary>Constructs a new TestIamPermissions request.</summary>
            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.ServiceBroker.v1.Data.GoogleIamV1TestIamPermissionsRequest body, string resource)
                : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }


            /// <summary>REQUIRED: The resource for which the policy detail is being requested. See the operation
            /// documentation for the appropriate value for this field.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ServiceBroker.v1.Data.GoogleIamV1TestIamPermissionsRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() { return Body; }

            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "testIamPermissions"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "POST"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "v1/{+resource}:testIamPermissions"; }
            }

            /// <summary>Initializes TestIamPermissions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "resource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resource",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^.+$",
                    });
            }

        }
    }
}

namespace Google.Apis.ServiceBroker.v1.Data
{    

    /// <summary>Associates `members` with a `role`.</summary>
    public class GoogleIamV1Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The condition that is associated with this binding. NOTE: An unsatisfied condition will not allow
        /// user access via current binding. Different bindings, including their conditions, are examined
        /// independently.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual GoogleTypeExpr Condition { get; set; } 

        /// <summary>Specifies the identities requesting access for a Cloud Platform resource. `members` can have the
        /// following values:
        ///
        /// * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a Google
        /// account.
        ///
        /// * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated with a Google
        /// account or a service account.
        ///
        /// * `user:{emailid}`: An email address that represents a specific Google account. For example,
        /// `alice@gmail.com` .
        ///
        /// * `serviceAccount:{emailid}`: An email address that represents a service account. For example, `my-other-
        /// app@appspot.gserviceaccount.com`.
        ///
        /// * `group:{emailid}`: An email address that represents a Google group. For example, `admins@example.com`.
        ///
        /// * `domain:{domain}`: The G Suite domain (primary) that represents all the users of that domain. For example,
        /// `google.com` or `example.com`.
        ///
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; } 

        /// <summary>Role that is assigned to `members`. For example, `roles/viewer`, `roles/editor`, or
        /// `roles/owner`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Defines an Identity and Access Management (IAM) policy. It is used to specify access control policies
    /// for Cloud Platform resources.
    ///
    /// A `Policy` consists of a list of `bindings`. A `binding` binds a list of `members` to a `role`, where the
    /// members can be user accounts, Google groups, Google domains, and service accounts. A `role` is a named list of
    /// permissions defined by IAM.
    ///
    /// **JSON Example**
    ///
    /// { "bindings": [ { "role": "roles/owner", "members": [ "user:mike@example.com", "group:admins@example.com",
    /// "domain:google.com", "serviceAccount:my-other-app@appspot.gserviceaccount.com" ] }, { "role": "roles/viewer",
    /// "members": ["user:sean@example.com"] } ] }
    ///
    /// **YAML Example**
    ///
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com - serviceAccount:my-
    /// other-app@appspot.gserviceaccount.com role: roles/owner - members: - user:sean@example.com role: roles/viewer
    ///
    /// For a description of IAM and its features, see the [IAM developer's
    /// guide](https://cloud.google.com/iam/docs).</summary>
    public class GoogleIamV1Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Associates a list of `members` to a `role`. `bindings` with no members will result in an
        /// error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<GoogleIamV1Binding> Bindings { get; set; } 

        /// <summary>`etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of
        /// a policy from overwriting each other. It is strongly suggested that systems make use of the `etag` in the
        /// read-modify-write cycle to perform policy updates in order to avoid race conditions: An `etag` is returned
        /// in the response to `getIamPolicy`, and systems are expected to put that etag in the request to
        /// `setIamPolicy` to ensure that their change will be applied to the same version of the policy.
        ///
        /// If no `etag` is provided in the call to `setIamPolicy`, then the existing policy is overwritten
        /// blindly.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; } 

    }    

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class GoogleIamV1SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to
        /// a few 10s of KB. An empty policy is a valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual GoogleIamV1Policy Policy { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class GoogleIamV1TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The set of permissions to check for the `resource`. Permissions with wildcards (such as '*' or
        /// 'storage.*') are not allowed. For more information see [IAM
        /// Overview](https://cloud.google.com/iam/docs/overview#permissions).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for `TestIamPermissions` method.</summary>
    public class GoogleIamV1TestIamPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of `TestPermissionsRequest.permissions` that the caller is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents an expression text. Example:
    ///
    /// title: "User account presence" description: "Determines whether the request has a user account" expression:
    /// "size(request.user) > 0"</summary>
    public class GoogleTypeExpr : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An optional description of the expression. This is a longer text which describes the expression,
        /// e.g. when hovered over it in a UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Textual representation of an expression in Common Expression Language syntax.
        ///
        /// The application context of the containing message determines which well-known feature set of CEL is
        /// supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; } 

        /// <summary>An optional string indicating the location of the expression for error reporting, e.g. a file name
        /// and a position in the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; } 

        /// <summary>An optional title for the expression, i.e. a short string describing its purpose. This can be used
        /// e.g. in UIs which allow to enter the expression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
