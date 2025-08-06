using SimpleHttp.Models.ValueObjects;

namespace SimpleHttp.Models;

public class StatusCodes
{
    // 1xx - Informational
    public static readonly StatusCode Continue = StatusCode.Create(100, "Continue");
    public static readonly StatusCode SwitchingProtocols = StatusCode.Create(101, "Switching Protocols");
    public static readonly StatusCode Processing = StatusCode.Create(102, "Processing");
    public static readonly StatusCode EarlyHints = StatusCode.Create(103, "Early Hints");

    // 2xx - Success
    public static readonly StatusCode Ok = StatusCode.Create(200, "OK");
    public static readonly StatusCode Created = StatusCode.Create(201, "Created");
    public static readonly StatusCode Accepted = StatusCode.Create(202, "Accepted");
    public static readonly StatusCode NonAuthoritativeInformation = StatusCode.Create(203, "Non-Authoritative Information");
    public static readonly StatusCode NoContent = StatusCode.Create(204, "No Content");
    public static readonly StatusCode ResetContent = StatusCode.Create(205, "Reset Content");
    public static readonly StatusCode PartialContent = StatusCode.Create(206, "Partial Content");
    public static readonly StatusCode MultiStatus = StatusCode.Create(207, "Multi-Status");
    public static readonly StatusCode AlreadyReported = StatusCode.Create(208, "Already Reported");
    public static readonly StatusCode ImUsed = StatusCode.Create(226, "IM Used");

    // 3xx - Redirection
    public static readonly StatusCode MultipleChoices = StatusCode.Create(300, "Multiple Choices");
    public static readonly StatusCode MovedPermanently = StatusCode.Create(301, "Moved Permanently");
    public static readonly StatusCode Found = StatusCode.Create(302, "Found");
    public static readonly StatusCode SeeOther = StatusCode.Create(303, "See Other");
    public static readonly StatusCode NotModified = StatusCode.Create(304, "Not Modified");
    public static readonly StatusCode UseProxy = StatusCode.Create(305, "Use Proxy");
    public static readonly StatusCode TemporaryRedirect = StatusCode.Create(307, "Temporary Redirect");
    public static readonly StatusCode PermanentRedirect = StatusCode.Create(308, "Permanent Redirect");

    // 4xx - Client Errors
    public static readonly StatusCode BadRequest = StatusCode.Create(400, "Bad Request");
    public static readonly StatusCode Unauthorized = StatusCode.Create(401, "Unauthorized");
    public static readonly StatusCode PaymentRequired = StatusCode.Create(402, "Payment Required");
    public static readonly StatusCode Forbidden = StatusCode.Create(403, "Forbidden");
    public static readonly StatusCode NotFound = StatusCode.Create(404, "Not Found");
    public static readonly StatusCode MethodNotAllowed = StatusCode.Create(405, "Method Not Allowed");
    public static readonly StatusCode NotAcceptable = StatusCode.Create(406, "Not Acceptable");
    public static readonly StatusCode ProxyAuthenticationRequired = StatusCode.Create(407, "Proxy Authentication Required");
    public static readonly StatusCode RequestTimeout = StatusCode.Create(408, "Request Timeout");
    public static readonly StatusCode Conflict = StatusCode.Create(409, "Conflict");
    public static readonly StatusCode Gone = StatusCode.Create(410, "Gone");
    public static readonly StatusCode LengthRequired = StatusCode.Create(411, "Length Required");
    public static readonly StatusCode PreconditionFailed = StatusCode.Create(412, "Precondition Failed");
    public static readonly StatusCode PayloadTooLarge = StatusCode.Create(413, "Payload Too Large");
    public static readonly StatusCode UriTooLong = StatusCode.Create(414, "URI Too Long");
    public static readonly StatusCode UnsupportedMediaType = StatusCode.Create(415, "Unsupported Media Type");
    public static readonly StatusCode RangeNotSatisfiable = StatusCode.Create(416, "Range Not Satisfiable");
    public static readonly StatusCode ExpectationFailed = StatusCode.Create(417, "Expectation Failed");
    public static readonly StatusCode ImATeapot = StatusCode.Create(418, "I'm a teapot");
    public static readonly StatusCode MisdirectedRequest = StatusCode.Create(421, "Misdirected Request");
    public static readonly StatusCode UnprocessableEntity = StatusCode.Create(422, "Unprocessable Entity");
    public static readonly StatusCode Locked = StatusCode.Create(423, "Locked");
    public static readonly StatusCode FailedDependency = StatusCode.Create(424, "Failed Dependency");
    public static readonly StatusCode TooEarly = StatusCode.Create(425, "Too Early");
    public static readonly StatusCode UpgradeRequired = StatusCode.Create(426, "Upgrade Required");
    public static readonly StatusCode PreconditionRequired = StatusCode.Create(428, "Precondition Required");
    public static readonly StatusCode TooManyRequests = StatusCode.Create(429, "Too Many Requests");
    public static readonly StatusCode RequestHeaderFieldsTooLarge = StatusCode.Create(431, "Request Header Fields Too Large");
    public static readonly StatusCode UnavailableForLegalReasons = StatusCode.Create(451, "Unavailable For Legal Reasons");

    // 5xx - Server Errors
    public static readonly StatusCode InternalServerError = StatusCode.Create(500, "Internal Server Error");
    public static readonly StatusCode NotImplemented = StatusCode.Create(501, "Not Implemented");
    public static readonly StatusCode BadGateway = StatusCode.Create(502, "Bad Gateway");
    public static readonly StatusCode ServiceUnavailable = StatusCode.Create(503, "Service Unavailable");
    public static readonly StatusCode GatewayTimeout = StatusCode.Create(504, "Gateway Timeout");
    public static readonly StatusCode HttpVersionNotSupported = StatusCode.Create(505, "HTTP Version Not Supported");
    public static readonly StatusCode VariantAlsoNegotiates = StatusCode.Create(506, "Variant Also Negotiates");
    public static readonly StatusCode InsufficientStorage = StatusCode.Create(507, "Insufficient Storage");
    public static readonly StatusCode LoopDetected = StatusCode.Create(508, "Loop Detected");
    public static readonly StatusCode NotExtended = StatusCode.Create(510, "Not Extended");
    public static readonly StatusCode NetworkAuthenticationRequired = StatusCode.Create(511, "Network Authentication Required");
}