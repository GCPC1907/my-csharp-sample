-- ����
CREATE TABLE sale_report (
     sale_date  DATE NOT NULL ,
     sale_item  VARCHAR(2) NOT NULL ,
     sale_money DECIMAL(10,2) NOT NULL,
     PRIMARY KEY(sale_date, sale_item)
);


-- ��������
DECLARE
  v_begin_day DATE;
  v_end_day DATE;
BEGIN
  v_begin_day := TO_DATE('2009-01-01', 'YYYY-MM-DD');
  v_end_day   := TO_DATE('2010-01-01', 'YYYY-MM-DD');

  WHILE v_begin_day < v_end_day LOOP
    INSERT INTO SALE_REPORT VALUES(v_begin_day,  'A',   1 );
    INSERT INTO SALE_REPORT VALUES(v_begin_day,  'B',   2 );
    INSERT INTO SALE_REPORT VALUES(v_begin_day,  'C',   3 );
    v_begin_day := v_begin_day + 1;
  END LOOP;
END;
/

-- ���Ժ���
CREATE OR REPLACE FUNCTION HelloWorldFunc
RETURN VARCHAR2
AS
BEGIN
  RETURN 'Hello World!';
END;
/






CREATE TABLE test_update_func (
	Code  	VARCHAR2(10)	PRIMARY KEY,
	Val		INT
);

-- ���Ժ���
-- �ú������������, �޷�ʹ��  SELECT  HelloWorldFuncWithUpdate('a')  FROM  dual  ����ѯ.
CREATE OR REPLACE FUNCTION HelloWorldFuncWithUpdate (
	p_Code  VARCHAR2
)
RETURN INT
AS
	v_result INT;
BEGIN
	SELECT 
		COUNT( 1 ) INTO v_result
	FROM
		test_update_func
	WHERE
		Code = p_Code;

	IF v_result = 1 THEN
		UPDATE 
			test_update_func
		SET
			Val = Val + 1
		WHERE
			Code = p_Code;
	ELSE
		INSERT INTO test_update_func (
			Code, Val
		) VALUES( 
			p_Code,  1 
		);	
	END IF;
	
	
	SELECT 
		Val INTO v_result
	FROM
		test_update_func
	WHERE
		Code = p_Code;
		
	RETURN v_result;
END;
/

/*

SQL> SELECT  HelloWorldFuncWithUpdate('a')  FROM  dual ;
SELECT  HelloWorldFuncWithUpdate('a')  FROM  dual
        *
�� 1 �г��ִ���:
ORA-14551: �޷��ڲ�ѯ��ִ�� DML ����
ORA-06512: �� "TEST.HELLOWORLDFUNCWITHUPDATE", line 23


*/




-- ���Է���ֵ����Ϊ CLOB �ĺ���
CREATE OR REPLACE FUNCTION HelloWorldFuncReturnClob
RETURN CLOB
AS
BEGIN
  RETURN 'Hello World! ���Ĳ��ԣ�';
END;
/




-- ���Դ洢����
CREATE OR REPLACE PROCEDURE HelloWorld2 (
  p_user_name IN     VARCHAR2,
  p_out_val   OUT    VARCHAR2,
  p_inout_val IN OUT VARCHAR2
) AS
BEGIN
   dbms_output.put_line('Hello ' || p_user_name || p_inout_val || '!');
   p_out_val := 'A';
   p_inout_val := 'B';
END HelloWorld2;
/

-- ���Է��ؽ�����ĺ���
create or replace package pkg_HelloWorld as
  -- ����ref cursor����
  type myrctype is ref cursor;
  --��������
  function getHelloWorld return myrctype;
end pkg_HelloWorld;
/

CREATE OR REPLACE package body pkg_HelloWorld as
  function getHelloWorld return myrctype
  IS
    return_cursor  myrctype;
  BEGIN
    OPEN return_cursor FOR 'SELECT ''Hello'' AS a, ''World'' AS B FROM dual';
    return return_cursor;
  END getHelloWorld;
end pkg_HelloWorld;
/







----------
--  SEQUENCE ����.
----------

CREATE SEQUENCE SEQ_TEST_EF
	INCREMENT BY 1    -- ÿ�ε���1
	START WITH 1       -- ��1��ʼ
	NOMAXVALUE      -- û�����ֵ
	MINVALUE 1       -- ��Сֵ=1
	NOCYCLE      -- ��ѭ��
;


-- �������Ա�. ID ������.  ���ݽ��� ������ �����к��л�ȡ.
CREATE TABLE test_seq_tab (
	id      INT,
	value   VARCHAR(10),
	PRIMARY KEY(id) 
);


-- ������.
CREATE OR REPLACE TRIGGER "T_SEQ_TEST_EF" BEFORE INSERT
ON test_seq_tab FOR EACH ROW
BEGIN
	SELECT SEQ_TEST_EF.NEXTVAL INTO :NEW.id FROM DUAL;
END;
/

