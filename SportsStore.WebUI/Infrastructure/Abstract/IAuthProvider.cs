using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.WebUI.Infrastructure.Abstract;

namespace SportsStore.WebUI.Infrastructure.Abstract
{
	public interface IAuthProvider
	{
		bool Authenticate(string username, string password);
	}
}
