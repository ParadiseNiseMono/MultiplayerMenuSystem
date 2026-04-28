// Paradise_NiseMono all rights deserved

#pragma once

#include "CoreMinimal.h"
#include "Blueprint/UserWidget.h"
#include "Menu.generated.h"

class UMultiplayerSessionsSubsystem;
class UButton;
/**
 * 
 */
UCLASS()
class MULTIPLAYERSESSIONS_API UMenu : public UUserWidget
{
	GENERATED_BODY()

public:
	UFUNCTION(BlueprintCallable, Category = "Menu")
	void MenuSetup();
	
	virtual bool Initialize();

protected:
	UFUNCTION()
	void HostButtonClicked();

	UFUNCTION()
	void JoinButtonClicked();

private:
	UPROPERTY(meta = (BindWidget))
	UButton* HostButton;

	UPROPERTY(meta = (BindWidget))
	UButton* JoinButton;

	UPROPERTY()
	UMultiplayerSessionsSubsystem* MultiplayerSessionsSubsystem;
};
