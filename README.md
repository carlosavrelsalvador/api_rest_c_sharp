cli

docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=VeryStr0ngP@ssw0rd" -p 1433:1433 --name sqlserver2022 --hostname sql --platform linux/amd64 -d mcr.microsoft.com/mssql/server:2022-latest


cli

sudo docker exec -it sql "bash"

>> actualizar los script --force

dotnet ef dbcontext scaffold "server=localhost;database=TestDB;user=SA;password=VeryStr0ngP@ssw0rd;TrustServerCertificate=true" Microsoft.EntityFrameworkCore.SqlServer -o Models --force


