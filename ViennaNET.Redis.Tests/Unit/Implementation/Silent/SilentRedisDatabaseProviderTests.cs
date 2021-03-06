﻿using ViennaNET.Redis.Implementation.Silent;
using NUnit.Framework;

namespace ViennaNET.Redis.Tests.Unit.Implementation.Silent
{
  [TestFixture(Category = "Unit", TestOf = typeof(SilentRedisDatabaseProvider))]
  public class SilentRedisDatabaseProviderTests
  {
    private SilentRedisDatabaseProvider _silentRedisDatabaseProviderMock;

    [OneTimeSetUp]
    public void SilentRedisDatabaseProviderTestsSetUp()
    {
      _silentRedisDatabaseProviderMock = new SilentRedisDatabaseProvider(null);
    }

    [Test]
    public void GetDatabase_RedisDatabaseProviderNull_DatabaseCreated()
    {
      var database = _silentRedisDatabaseProviderMock.GetDatabase();

      Assert.That(database, Is.Not.Null);
    }

    [Test]
    public void GetServer_RedisDatabaseProviderNull_ServerCreated()
    {
      var server = _silentRedisDatabaseProviderMock.GetServer(null);

      Assert.That(server, Is.Not.Null);
    }

    [Test]
    public void GetAllServers_RedisDatabaseProviderNull_EmptyServersCollection()
    {
      var servers = _silentRedisDatabaseProviderMock.GetAllServers();

      Assert.That(servers, Is.Empty);
    }
  }
}
