--------------------------------------------------------
--  파일이 생성됨 - 수요일-12월-14-2022   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table ANNUALSTATUS
--------------------------------------------------------

  CREATE TABLE "CSHYEONJU"."ANNUALSTATUS" 
   (	"EMPNO" VARCHAR2(20 BYTE), 
	"YEAR" VARCHAR2(20 BYTE), 
	"TYPE" VARCHAR2(20 BYTE), 
	"TOTAL" VARCHAR2(20 BYTE), 
	"LEFTOVER" VARCHAR2(20 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index ANNUALSTATUS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "CSHYEONJU"."ANNUALSTATUS_PK" ON "CSHYEONJU"."ANNUALSTATUS" ("EMPNO", "YEAR", "TYPE") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  Constraints for Table ANNUALSTATUS
--------------------------------------------------------

  ALTER TABLE "CSHYEONJU"."ANNUALSTATUS" MODIFY ("YEAR" NOT NULL ENABLE);
  ALTER TABLE "CSHYEONJU"."ANNUALSTATUS" MODIFY ("TYPE" NOT NULL ENABLE);
  ALTER TABLE "CSHYEONJU"."ANNUALSTATUS" MODIFY ("EMPNO" NOT NULL ENABLE);
  ALTER TABLE "CSHYEONJU"."ANNUALSTATUS" ADD CONSTRAINT "ANNUALSTATUS_PK" PRIMARY KEY ("EMPNO", "YEAR", "TYPE")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table ANNUALSTATUS
--------------------------------------------------------

  ALTER TABLE "CSHYEONJU"."ANNUALSTATUS" ADD CONSTRAINT "ANNUALSTATUS_EMP" FOREIGN KEY ("EMPNO")
	  REFERENCES "CSHYEONJU"."EMP" ("NO") ENABLE;
