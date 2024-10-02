USE [StrategyMack];  -- Use the database
CREATE LOGIN StrategyMack_App_User WITH PASSWORD = 'VusB/*[HA$hD5JzCnZF8-@';
CREATE USER StrategyMack_App_User FOR LOGIN StrategyMack_App_User;

-- Add all the roles
ALTER ROLE db_datareader ADD MEMBER [StrategyMack_App_User];
ALTER ROLE db_datawriter ADD MEMBER [StrategyMack_App_User];
ALTER ROLE db_ddladmin ADD MEMBER [StrategyMack_App_User];


-- Or add them One By One
-- Reader
GRANT SELECT ON SCHEMA::[dbo] TO [StrategyMack_App_User];
-- Writer
GRANT INSERT, UPDATE, DELETE ON SCHEMA::[dbo] TO [StrategyMack_App_User];
-- DDL
GRANT ALTER, CREATE TABLE, CREATE VIEW, CREATE PROCEDURE, CREATE FUNCTION ON SCHEMA::[dbo] TO [StrategyMack_App_User];
-- Execute
GRANT EXECUTE ON SCHEMA::[dbo] TO [StrategyMack_App_User];
