C# ���룬 ����  Python �ű�.


��������

1.����һ������̨����. O0101_DotNetCallPython.


2.���� Nuget ����������� IronPython �� Ȼ��װ��

�˲������Զ�������в�����
�ѽ����á�IronPython����ӵ���Ŀ��O0101_CallPython��
�ѽ����á�IronPython.Modules����ӵ���Ŀ��O0101_CallPython��
�ѽ����á�IronPython.SQLite����ӵ���Ŀ��O0101_CallPython��
�ѽ����á�IronPython.Wpf����ӵ���Ŀ��O0101_CallPython��
�ѽ����á�Microsoft.Dynamic����ӵ���Ŀ��O0101_CallPython��
�ѽ����á�Microsoft.Scripting.AspNet����ӵ���Ŀ��O0101_CallPython��
�ѽ����á�Microsoft.Scripting����ӵ���Ŀ��O0101_CallPython��
�ѽ����á�Microsoft.Scripting.Metadata����ӵ���Ŀ��O0101_CallPython��




3.���Python�ļ�����ǰ����Ŀ��

����һ���ı��ļ�����Ϊ��hello.py, �༭����
def welcome(name):
    return "hello" + name
�Ѹ��ļ���ӵĵ�ǰ����Ŀ�С�

�� Visual Studio �У������ļ���������Ŀ��
���Ƶ����Ŀ¼�������������
���ɲ�������


4. ��дC# ���룬 ���� hello.py �ű��ļ��ж���ķ��� 



--------------------------------------------------------------------------------

���ڼ��� Python ��׼ģ�� ��ע�����

���磬�� py �ļ��С�
�� 
import hashlib

��ô�� ���� ���룬 �� Python �������У� һ������û�С�
�� C# �� IronPython ���õ�ʱ�� ��ʾ   No module named  hashlib


����취��
�� py �ļ��У���������Ĵ���

import sys
sys.path.append("C:\Python27\Lib")

ע�� ����� C:\Python27\Lib��  ��Ŀ������� Pythond ��װ��Ŀ¼��





--------------------------------------------------------------------------------

���ڼ��� Python ������ģ�� ��ע�����

���磬�� py �ļ��С�
�� 
import requests


��������£� ���ȣ� �� Python ��� Ҫ��װ���  ������ģ�顣
Ȼ����Ҫ�� Python ��� 
���� import sys;print sys.path �۲� ��ǰ������ sys.path 


Ȼ�� �� py �ļ��У� ��������� sys.path �� ����Ӧ���޸ġ�
��ע����Ϊ�ǵ�����ģ�飬 ��ʱ�� ֻ�� C:\\Python27\\Lib  �ǲ����ġ� ��

import sys
sys.path.append('C:\\Python27\\Lib')
sys.path.append('C:\\Python27\\lib\\site-packages\\setuptools-6.0.2-py2.7.egg')
sys.path.append('C:\\Python27\\lib\\site-packages\\requests-2.9.1-py2.7.egg')



