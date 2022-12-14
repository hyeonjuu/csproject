--------------------------------------------------------
--  파일이 생성됨 - 수요일-12월-14-2022   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table ATTENDANCE
--------------------------------------------------------

  CREATE TABLE "CSHYEONJU"."ATTENDANCE" 
   (	"EMPNO" VARCHAR2(20 BYTE), 
	"ATNDDATE" DATE, 
	"ATNDTYPE" VARCHAR2(20 BYTE), 
	"STARTTIME" VARCHAR2(20 BYTE), 
	"STOPTIME" VARCHAR2(20 BYTE), 
	"NOTE" VARCHAR2(1024 BYTE), 
	"CONFIRM" VARCHAR2(20 BYTE), 
	"CONFIRMUSER" VARCHAR2(20 BYTE), 
	"CONFIRMTIME" VARCHAR2(50 BYTE), 
	"TIME" VARCHAR2(20 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index ATTENDANCE_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "CSHYEONJU"."ATTENDANCE_PK" ON "CSHYEONJU"."ATTENDANCE" ("EMPNO", "ATNDDATE", "ATNDTYPE") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  Constraints for Table ATTENDANCE
--------------------------------------------------------

  ALTER TABLE "CSHYEONJU"."ATTENDANCE" MODIFY ("EMPNO" NOT NULL ENABLE);
  ALTER TABLE "CSHYEONJU"."ATTENDANCE" MODIFY ("ATNDDATE" NOT NULL ENABLE);
  ALTER TABLE "CSHYEONJU"."ATTENDANCE" MODIFY ("ATNDTYPE" NOT NULL ENABLE);
  ALTER TABLE "CSHYEONJU"."ATTENDANCE" ADD CONSTRAINT "ATTENDANCE_PK" PRIMARY KEY ("EMPNO", "ATNDDATE", "ATNDTYPE")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table ATTENDANCE
--------------------------------------------------------

  ALTER TABLE "CSHYEONJU"."ATTENDANCE" ADD CONSTRAINT "CONFIMUSER_EMP" FOREIGN KEY ("CONFIRMUSER")
	  REFERENCES "CSHYEONJU"."EMP" ("NO") ENABLE;
  ALTER TABLE "CSHYEONJU"."ATTENDANCE" ADD CONSTRAINT "EMPNO_EMP" FOREIGN KEY ("EMPNO")
	  REFERENCES "CSHYEONJU"."EMP" ("NO") ENABLE;
