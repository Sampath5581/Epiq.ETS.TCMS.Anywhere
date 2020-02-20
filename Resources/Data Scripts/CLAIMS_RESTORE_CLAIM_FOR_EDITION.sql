DECLARE @RC int

EXECUTE @RC = [TCMS].[CreateClaim] 
   @ClaimName = 'Automated DO NOT DELETE Test Edit Claim Basic Form'
  ,@ClaimNumber = 123
  ,@Suffix= 'AutoEdit'
  ,@OrderNumber=0
  ,@ModifiedByUserId=3
  ,@CaseId=1092
  ,@CreditorParticipationId = 12926
  ,@ClaimStatusId = 4
  ,@CategoryId = 2
  ,@ChartOfAccountId = 69
  ,@ChartOfAccountSubNumberId = NULL
  ,@ScheduleAmount = '600.00'
  ,@ClaimedAmount = '5000.00'
  ,@AllowedAmount = '400.00'
  ,@ReservedAmount = '300.00'
  ,@PaySequence = 220
  ,@DateFiled = '2016-09-01 00:00:00'
  ,@AmendsClaimNumber = NULL
  ,@AmendsClaimNumberSuffix = ABC
  ,@AmendsClaimVersion = 123
  ,@AmendedByClaimNumber = NULL
  ,@AmendedByClaimNumberSuffix = 'DEF'
  ,@AmendedByClaimVersion = 456 
  ,@CreditorAccountNumber = 123456789
  ,@CheckDescription = 'Initial Description'
  ,@IsWageClaim = 0
  ,@IsNonCompensable = 0
  ,@ExcludeFromUFR = 0
  ,@IsNonDischarged = 0
  ,@IsReaffirmed = 0
  ,@InternalNote = 'Initial Internal Note'
  ,@RegisterNote = 'Initial Register Note'
  ,@Office = 'crose'
  ,@ParticipantFirstName = NULL
  ,@ParticipantMiddleName  = NULL
  ,@ParticipantLastName  = NULL
  ,@ParticipantPrefixName  = NULL
  ,@ParticipantSuffixName  = NULL
  ,@ObjectionCodeId = NULL
  ,@ParticipantId =  NULL