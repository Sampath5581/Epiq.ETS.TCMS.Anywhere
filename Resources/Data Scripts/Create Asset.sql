DECLARE @CaseId int = (SELECT CaseId FROM [dbo].[Case] WHERE CoreCaseNumber=@CoreCaseNumber);
DECLARE	@return_value int
--jkjda
EXEC	@return_value = [TCMS].[CreateAsset]		
		@TrusteeValue = 200,
		@PetitionValue = 100,
		@LienAmount = 300,
		@EstimatedSaleCosts = 400,
		@ExemptAmount = 500,
		@Name = @ItemName,
		@Number = 1,
		@CaseId =  @CaseId,
		@DefaultChartOfAccountId = 173,
		@ChartOfAccountTypeId = 27,
		@AbandonmentStatusId = 1,
		@AssetTypeId = 1,
		@TrusteeValueTypeId = 1,
		@AssetScheduleTypeId = 0,
		@ExemptionLaw = '0',
		@InitialValue = 0,
		@CurrentValue = 0,
		@SubCodeId = 3,
		@ReservedNote = 'I am so reserved right now.',
		@ReservedValue = 1,
		@FormOneNote = 'Something in the Form',
		@FullAdministratedDate = '2020-09-01 00:00:00',
		@USTFirstReport = '2030-09-01 00:00:00',
		@USTSecondReport = '2040-09-01 00:00:00',
		@OwnedAmount = 600,
		@OwnershipTypeId = 1,
		@Office = @OfficeCode,
		@ToCreate = 0,
		@ToDelete = 0