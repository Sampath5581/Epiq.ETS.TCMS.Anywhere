--;WITH MaxAsOfDate AS 
--(
--      SELECT
--            eBal1.BankAccountId
--            , MAX(eBal1.AsOfDate) AS "AsOfDate"
--      FROM
--            dbo.BankAccountElectronicBalance eBal1
--        JOIN dbo.BankAccount ba1 ON ba1.BankAccountId = eBal1.BankAccountId  
--      WHERE 
--            eBal1.IsPotentialDuplicate = 0
--            AND eBal1.IsDeleted = 0
--            AND ba1.BankAccountNumber = '9701837878'   
--      GROUP BY
--            eBal1.BankAccountId
--), FirstOnMaxDate AS 
--(
--      SELECT
--                  MIN(eBal2.BankAccountElectronicBalanceId) AS BankAccountElectronicBalanceId
--      FROM
--            dbo.BankAccountElectronicBalance eBal2
--        JOIN dbo.BankAccount ba2 ON ba2.BankAccountId = eBal2.BankAccountId
--      INNER JOIN MaxAsOfDate md
--            ON md.BankAccountId = eBal2.BankAccountId
--            AND md.AsOfDate = eBal2.AsOfDate
--      WHERE   
--            eBal2.IsPotentialDuplicate = 0
--            AND eBal2.IsDeleted = 0
--            AND ba2.BankAccountNumber = '9701837878'   
--            GROUP BY eBal2.BankAccountId
--)
--SELECT BankAccountElectronicBalanceId 
--FROM FirstOnMaxDate



--UPDATE dbo.BankAccountElectronicBalance
--SET EBalance = -100
--WHERE BankAccountElectronicBalanceId = 81411