--------------------------------------------------------
--  파일이 생성됨 - 수요일-12월-14-2022   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table WORKSTATUS
--------------------------------------------------------

  CREATE TABLE "CSHYEONJU"."WORKSTATUS" 
   (	"EMPNO" VARCHAR2(20 BYTE), 
	"MONTH" VARCHAR2(20 BYTE), 
	"PLANTIME" NUMBER, 
	"CURRENTTIME" NUMBER
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index WORKSTATUS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "CSHYEONJU"."WORKSTATUS_PK" ON "CSHYEONJU"."WORKSTATUS" ("EMPNO", "MONTH") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  Constraints for Table WORKSTATUS
--------------------------------------------------------

  ALTER TABLE "CSHYEONJU"."WORKSTATUS" MODIFY ("EMPNO" NOT NULL ENABLE);
  ALTER TABLE "CSHYEONJU"."WORKSTATUS" MODIFY ("MONTH" NOT NULL ENABLE);
  ALTER TABLE "CSHYEONJU"."WORKSTATUS" ADD CONSTRAINT "WORKSTATUS_PK" PRIMARY KEY ("EMPNO", "MONTH")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table WORKSTATUS
--------------------------------------------------------

  ALTER TABLE "CSHYEONJU"."WORKSTATUS" ADD CONSTRAINT "WORKSTATUS_EMP" FOREIGN KEY ("EMPNO")
	  REFERENCES "CSHYEONJU"."EMP" ("NO") ENABLE;
