// Paradise_NiseMono all rights deserved


#include "MultiplayerSessionsSubsystem.h"
#include "OnlineSubsystem.h"
#include "OnlineSubsystemUtils.h"

UMultiplayerSessionsSubsystem::UMultiplayerSessionsSubsystem()
{
	IOnlineSubsystem* Subsystem = Online::GetSubsystem(UObject::GetWorld());
	
	if (Subsystem)
	{
		SessionInterface = Subsystem->GetSessionInterface();
	}
}
