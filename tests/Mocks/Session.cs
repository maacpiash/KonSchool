using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.AspNetCore.Http;
using static System.Text.Encoding;

namespace KonSchool.Tests.Mocks
{
	class MockSession : ISession
	{
		public Dictionary<string, string> session; // This is where all the values will be stored
		public MockSession() => session = new Dictionary<string, string>();

		public string Id => "";
		public bool IsAvailable => true;
		public IEnumerable<string> Keys => session.Keys;

		public void Clear() => session.Clear();
		public Task CommitAsync(CancellationToken cancellationToken = default) => null;
		public Task LoadAsync(CancellationToken cancellationToken = default) => null;
		public void Remove(string key) => session.Remove(key);
		public void Set(string key, byte[] value) => session[key] = UTF8.GetString(value, 0, value.Length);

		public bool TryGetValue(string key, out byte[] value)
		{
			var returnValue = session.TryGetValue(key, out string val);
			value = val is null ? null : UTF8.GetBytes(val);
			return returnValue;
		}
	}
}
