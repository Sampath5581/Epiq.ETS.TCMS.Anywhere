/****** Script for Claims Edit - 2100 Trustee Compensation  ******/

--Select * from [TCMS21].[dbo].[ChartOfAccount] coa where coa.Number='2100' and coa.IsSeed=1
--SELECT * FROM [TCMS21].[dbo].[Claim] WHERE ChartOfAccountId=25 AND CaseId = 1065

--Change Serial Numbers to find claim on UI and set specific data
--Claim on Case 1075
--Set UTC 2100 Trustee compensation
UPDATE [TCMS21].[dbo].[Claim] SET ClaimNumber=NULL, ClaimNumberSuffix='TAEstmtd2100', ChartOfAccountId=25, IsFrozen = 0 WHERE ClaimId = 3904;
--Claim on Case 1065
UPDATE [TCMS21].[dbo].[Claim] SET ClaimNumber=NULL, ClaimNumberSuffix='TAFrozen2100', ChartOfAccountId=25, IsFrozen = 1 WHERE ClaimId = 878;

