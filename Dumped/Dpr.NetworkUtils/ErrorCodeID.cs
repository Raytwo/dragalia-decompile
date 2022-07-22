namespace Dpr.NetworkUtils;

public enum ErrorCodeID : uint
{
	ErrorNSATokenAuth = 0u,
	ErrorSerialServerMaintenance = 2u,
	ErrorSerialServiceEnd = 4u,
	ErrorSerialInvalidParameter = 6u,
	ErrorSerialUnexpected = 8u,
	ErrorSerialIntgernal = 10u,
	ErrorConnectBCATServer = 12u,
	ErrorDisconnectionServer = 14u,
	ErrorTimeout = 15u,
	ErrorDisconnectionP2P = 16u,
	ErrorValidateServer = 47u,
	ErrorValidateServerMaintenance = 48u,
	ErrorDisconnectionSession = 49u,
	ErrorVersion = 50u,
	FatalError = 9999u,
	NUM = 10000u
}
