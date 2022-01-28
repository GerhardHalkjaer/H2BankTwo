# Bank H2

### Desciption
bank simulering

#### Auther
Gerhard

[GitHub](https://github.com/GerhardHalkjaer/H2BankTwo)

### Method description
missing enums

##### createAccount
creates and new account with given account name and id and updates accountNumberCouter

3 types of account type

##### deposite
adds the amount to the account balance and bank beholder

##### withdraw
reduces the amount to the account balanace and bank beholder

##### balance
returns the accounts balance

##### GetAccountList

converts the list of accounts to list of AccountListItem and returns it.




##### ChargeInterest
charge interest depending on the account type

### Known issues

### ChangeLog

##### 0.8
accounts are now being saved in an xml file in storage.

##### 0.7
logging added to:

createAccount, Deposit, withdraw, opening program and overdraft Exception

##### 0.6
added overdraft exceptions to relavent accounts

##### 0.5
move classes around, now using repositorys and models

added bank interface

added getAccountList returning list of AccountListItem

##### 0.4
added to have 3 type of accounts

added chargeInterest

changed createAccount to acomedate the 3 type of accounts.

##### 0.3
changed to support more account
changed deposite withdraw and get balance to require account number

##### 0.2
added menu

added bank beholder der også kan vises

##### 0.1
bank etablers med one account

kan create account med navn

kan deposit og withdraw og get balance

### Contact info
none