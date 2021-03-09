一、dbfirst 模式生成脚本，生成命令如下：
&"tools/cli.ps1" -CoreProject "SSS.FrameWork.Core" -EntryProject "SSS.FrameWork.Web.Entry" -ConnectionName "OracleConnectionString" -DbProvider "Oracle.EntityFrameworkCore"

更多参见：https://dotnetchina.gitee.io/furion/docs/dbcontext-db-first

二、EFCORE 执行比较严格的类型映射查检，所以请严格控制数据库的类型长度，由其是NUMBER类型，具体类型映射参见以下地址
https://docs.oracle.com/en/database/oracle/oracle-data-access-components/19.3/odpnt/EFCoreDataTypeMapping.html#GUID-484E9D3A-8E42-417F-9591-F2E7305E3F6A