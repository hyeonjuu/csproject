--------------------------------------------------------
--  ������ ������ - ������-12��-14-2022   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table ADDITIONAL
--------------------------------------------------------

  CREATE TABLE "CSHYEONJU"."ADDITIONAL" 
   (	"NO" VARCHAR2(20 BYTE), 
	"BIRTH" DATE, 
	"TYPE" VARCHAR2(20 BYTE), 
	"WORKINGHOUR" NUMBER, 
	"VACATIONHOUR" NUMBER, 
	"ENTRY" DATE
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
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
--  DDL for Table COMPANY
--------------------------------------------------------

  CREATE TABLE "CSHYEONJU"."COMPANY" 
   (	"CNAME" VARCHAR2(20 BYTE), 
	"FOUNDING" DATE
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table DEPT
--------------------------------------------------------

  CREATE TABLE "CSHYEONJU"."DEPT" 
   (	"CODE" VARCHAR2(20 BYTE), 
	"NAME" VARCHAR2(20 BYTE), 
	"COMPANY" VARCHAR2(20 BYTE), 
	"LOCATION" VARCHAR2(50 BYTE), 
	"SENIORDEPT" VARCHAR2(20 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table EMP
--------------------------------------------------------

  CREATE TABLE "CSHYEONJU"."EMP" 
   (	"NO" VARCHAR2(20 BYTE), 
	"PASSWORD" VARCHAR2(20 BYTE), 
	"NAME" VARCHAR2(20 BYTE), 
	"DEPT" VARCHAR2(20 BYTE), 
	"RANK" VARCHAR2(20 BYTE), 
	"TEL" VARCHAR2(20 BYTE), 
	"EMAIL" VARCHAR2(40 BYTE), 
	"STATUS" VARCHAR2(20 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
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
--  DDL for Index EMP_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "CSHYEONJU"."EMP_PK" ON "CSHYEONJU"."EMP" ("NO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
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
--  DDL for Index DEPT_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "CSHYEONJU"."DEPT_PK" ON "CSHYEONJU"."DEPT" ("CODE") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index COMPANY_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "CSHYEONJU"."COMPANY_PK" ON "CSHYEONJU"."COMPANY" ("CNAME") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
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
--  DDL for Index ANNUALSTATUS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "CSHYEONJU"."ANNUALSTATUS_PK" ON "CSHYEONJU"."ANNUALSTATUS" ("EMPNO", "YEAR", "TYPE") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index ADDITIONAL_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "CSHYEONJU"."ADDITIONAL_PK" ON "CSHYEONJU"."ADDITIONAL" ("NO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  Constraints for Table DEPT
--------------------------------------------------------

  ALTER TABLE "CSHYEONJU"."DEPT" MODIFY ("CODE" NOT NULL ENABLE);
  ALTER TABLE "CSHYEONJU"."DEPT" ADD CONSTRAINT "DEPT_PK" PRIMARY KEY ("CODE")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table EMP
--------------------------------------------------------

  ALTER TABLE "CSHYEONJU"."EMP" MODIFY ("NO" NOT NULL ENABLE);
  ALTER TABLE "CSHYEONJU"."EMP" ADD CONSTRAINT "EMP_PK" PRIMARY KEY ("NO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table COMPANY
--------------------------------------------------------

  ALTER TABLE "CSHYEONJU"."COMPANY" MODIFY ("CNAME" NOT NULL ENABLE);
  ALTER TABLE "CSHYEONJU"."COMPANY" ADD CONSTRAINT "COMPANY_PK" PRIMARY KEY ("CNAME")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
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
--  Constraints for Table ADDITIONAL
--------------------------------------------------------

  ALTER TABLE "CSHYEONJU"."ADDITIONAL" MODIFY ("NO" NOT NULL ENABLE);
  ALTER TABLE "CSHYEONJU"."ADDITIONAL" ADD CONSTRAINT "ADDITIONAL_PK" PRIMARY KEY ("NO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
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
--  Ref Constraints for Table ADDITIONAL
--------------------------------------------------------

  ALTER TABLE "CSHYEONJU"."ADDITIONAL" ADD CONSTRAINT "ADDITIONAL" FOREIGN KEY ("NO")
	  REFERENCES "CSHYEONJU"."EMP" ("NO") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table ANNUALSTATUS
--------------------------------------------------------

  ALTER TABLE "CSHYEONJU"."ANNUALSTATUS" ADD CONSTRAINT "ANNUALSTATUS_EMP" FOREIGN KEY ("EMPNO")
	  REFERENCES "CSHYEONJU"."EMP" ("NO") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table ATTENDANCE
--------------------------------------------------------

  ALTER TABLE "CSHYEONJU"."ATTENDANCE" ADD CONSTRAINT "CONFIMUSER_EMP" FOREIGN KEY ("CONFIRMUSER")
	  REFERENCES "CSHYEONJU"."EMP" ("NO") ENABLE;
  ALTER TABLE "CSHYEONJU"."ATTENDANCE" ADD CONSTRAINT "EMPNO_EMP" FOREIGN KEY ("EMPNO")
	  REFERENCES "CSHYEONJU"."EMP" ("NO") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table DEPT
--------------------------------------------------------

  ALTER TABLE "CSHYEONJU"."DEPT" ADD CONSTRAINT "DEPT_COMPANY" FOREIGN KEY ("COMPANY")
	  REFERENCES "CSHYEONJU"."COMPANY" ("CNAME") ENABLE;
  ALTER TABLE "CSHYEONJU"."DEPT" ADD CONSTRAINT "DEPT_SENIORDEPT" FOREIGN KEY ("SENIORDEPT")
	  REFERENCES "CSHYEONJU"."DEPT" ("CODE") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table EMP
--------------------------------------------------------

  ALTER TABLE "CSHYEONJU"."EMP" ADD CONSTRAINT "DEPT_EMP" FOREIGN KEY ("DEPT")
	  REFERENCES "CSHYEONJU"."DEPT" ("CODE") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table WORKSTATUS
--------------------------------------------------------

  ALTER TABLE "CSHYEONJU"."WORKSTATUS" ADD CONSTRAINT "WORKSTATUS_EMP" FOREIGN KEY ("EMPNO")
	  REFERENCES "CSHYEONJU"."EMP" ("NO") ENABLE;