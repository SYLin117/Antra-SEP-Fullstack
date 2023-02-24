<Query Kind="Statements">
  <Connection>
    <ID>83f7d4c5-c449-4a0d-8276-c485fae2a4ba</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <Database>Northwind</Database>
    <DriverData>
      <LegacyMFA>false</LegacyMFA>
    </DriverData>
  </Connection>
  <RuntimeVersion>6.0</RuntimeVersion>
</Query>

var result = Products.Where(p => p.UnitPrice > 10).Select(p => new {p.ProductName, p.UnitPrice});
result.Dump();