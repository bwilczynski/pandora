using Pandora.Definitions.Attributes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.EventHub.v2021_01_01_preview.NetworkRuleSets
{
	internal class NamespacesGetNetworkRuleSet : GetOperation
	{
		public override ResourceID? ResourceId()
		{
			return new NamespaceId();
		}

		public override object? ResponseObject()
		{
			return new NetworkRuleSet();
		}

		public override string? UriSuffix()
		{
			return "/networkRuleSets/default";
		}
	}
}