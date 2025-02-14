// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.KubernetesConfiguration.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.KubernetesConfiguration.Samples
{
    public partial class Sample_KubernetesClusterExtensionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateExtension()
        {
            // Generated from example definition: specification/kubernetesconfiguration/resource-manager/Microsoft.KubernetesConfiguration/stable/2022-11-01/examples/CreateExtension.json
            // this example is just showing the usage of "Extensions_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId1";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this KubernetesClusterExtensionResource
            string clusterRp = "Microsoft.Kubernetes";
            string clusterResourceName = "connectedClusters";
            string clusterName = "clusterName1";
            KubernetesClusterExtensionCollection collection = resourceGroupResource.GetKubernetesClusterExtensions(clusterRp, clusterResourceName, clusterName);

            // invoke the operation
            string extensionName = "ClusterMonitor";
            KubernetesClusterExtensionData data = new KubernetesClusterExtensionData()
            {
                ExtensionType = "azuremonitor-containers",
                AutoUpgradeMinorVersion = true,
                ReleaseTrain = "Preview",
                Scope = new KubernetesClusterExtensionScope()
                {
                    ClusterReleaseNamespace = "kube-system",
                },
                ConfigurationSettings =
{
["omsagent.env.clusterName"] = "clusterName1",
["omsagent.secret.wsid"] = "a38cef99-5a89-52ed-b6db-22095c23664b",
},
                ConfigurationProtectedSettings =
{
["omsagent.secret.key"] = "secretKeyValue01",
},
            };
            ArmOperation<KubernetesClusterExtensionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, extensionName, data);
            KubernetesClusterExtensionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KubernetesClusterExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateExtensionWithPlan()
        {
            // Generated from example definition: specification/kubernetesconfiguration/resource-manager/Microsoft.KubernetesConfiguration/stable/2022-11-01/examples/CreateExtensionWithPlan.json
            // this example is just showing the usage of "Extensions_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId1";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this KubernetesClusterExtensionResource
            string clusterRp = "Microsoft.Kubernetes";
            string clusterResourceName = "connectedClusters";
            string clusterName = "clusterName1";
            KubernetesClusterExtensionCollection collection = resourceGroupResource.GetKubernetesClusterExtensions(clusterRp, clusterResourceName, clusterName);

            // invoke the operation
            string extensionName = "azureVote";
            KubernetesClusterExtensionData data = new KubernetesClusterExtensionData()
            {
                Plan = new ArmPlan("azure-vote-standard", "Microsoft", "azure-vote-standard-offer-id"),
                ExtensionType = "azure-vote",
                AutoUpgradeMinorVersion = true,
                ReleaseTrain = "Preview",
            };
            ArmOperation<KubernetesClusterExtensionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, extensionName, data);
            KubernetesClusterExtensionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KubernetesClusterExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetExtension()
        {
            // Generated from example definition: specification/kubernetesconfiguration/resource-manager/Microsoft.KubernetesConfiguration/stable/2022-11-01/examples/GetExtension.json
            // this example is just showing the usage of "Extensions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId1";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this KubernetesClusterExtensionResource
            string clusterRp = "Microsoft.Kubernetes";
            string clusterResourceName = "connectedClusters";
            string clusterName = "clusterName1";
            KubernetesClusterExtensionCollection collection = resourceGroupResource.GetKubernetesClusterExtensions(clusterRp, clusterResourceName, clusterName);

            // invoke the operation
            string extensionName = "ClusterMonitor";
            KubernetesClusterExtensionResource result = await collection.GetAsync(extensionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KubernetesClusterExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetExtension()
        {
            // Generated from example definition: specification/kubernetesconfiguration/resource-manager/Microsoft.KubernetesConfiguration/stable/2022-11-01/examples/GetExtension.json
            // this example is just showing the usage of "Extensions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId1";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this KubernetesClusterExtensionResource
            string clusterRp = "Microsoft.Kubernetes";
            string clusterResourceName = "connectedClusters";
            string clusterName = "clusterName1";
            KubernetesClusterExtensionCollection collection = resourceGroupResource.GetKubernetesClusterExtensions(clusterRp, clusterResourceName, clusterName);

            // invoke the operation
            string extensionName = "ClusterMonitor";
            bool result = await collection.ExistsAsync(extensionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetExtension()
        {
            // Generated from example definition: specification/kubernetesconfiguration/resource-manager/Microsoft.KubernetesConfiguration/stable/2022-11-01/examples/GetExtension.json
            // this example is just showing the usage of "Extensions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId1";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this KubernetesClusterExtensionResource
            string clusterRp = "Microsoft.Kubernetes";
            string clusterResourceName = "connectedClusters";
            string clusterName = "clusterName1";
            KubernetesClusterExtensionCollection collection = resourceGroupResource.GetKubernetesClusterExtensions(clusterRp, clusterResourceName, clusterName);

            // invoke the operation
            string extensionName = "ClusterMonitor";
            NullableResponse<KubernetesClusterExtensionResource> response = await collection.GetIfExistsAsync(extensionName);
            KubernetesClusterExtensionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                KubernetesClusterExtensionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetExtensionWithPlan()
        {
            // Generated from example definition: specification/kubernetesconfiguration/resource-manager/Microsoft.KubernetesConfiguration/stable/2022-11-01/examples/GetExtensionWithPlan.json
            // this example is just showing the usage of "Extensions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId1";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this KubernetesClusterExtensionResource
            string clusterRp = "Microsoft.Kubernetes";
            string clusterResourceName = "connectedClusters";
            string clusterName = "clusterName1";
            KubernetesClusterExtensionCollection collection = resourceGroupResource.GetKubernetesClusterExtensions(clusterRp, clusterResourceName, clusterName);

            // invoke the operation
            string extensionName = "azureVote";
            KubernetesClusterExtensionResource result = await collection.GetAsync(extensionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KubernetesClusterExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetExtensionWithPlan()
        {
            // Generated from example definition: specification/kubernetesconfiguration/resource-manager/Microsoft.KubernetesConfiguration/stable/2022-11-01/examples/GetExtensionWithPlan.json
            // this example is just showing the usage of "Extensions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId1";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this KubernetesClusterExtensionResource
            string clusterRp = "Microsoft.Kubernetes";
            string clusterResourceName = "connectedClusters";
            string clusterName = "clusterName1";
            KubernetesClusterExtensionCollection collection = resourceGroupResource.GetKubernetesClusterExtensions(clusterRp, clusterResourceName, clusterName);

            // invoke the operation
            string extensionName = "azureVote";
            bool result = await collection.ExistsAsync(extensionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetExtensionWithPlan()
        {
            // Generated from example definition: specification/kubernetesconfiguration/resource-manager/Microsoft.KubernetesConfiguration/stable/2022-11-01/examples/GetExtensionWithPlan.json
            // this example is just showing the usage of "Extensions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId1";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this KubernetesClusterExtensionResource
            string clusterRp = "Microsoft.Kubernetes";
            string clusterResourceName = "connectedClusters";
            string clusterName = "clusterName1";
            KubernetesClusterExtensionCollection collection = resourceGroupResource.GetKubernetesClusterExtensions(clusterRp, clusterResourceName, clusterName);

            // invoke the operation
            string extensionName = "azureVote";
            NullableResponse<KubernetesClusterExtensionResource> response = await collection.GetIfExistsAsync(extensionName);
            KubernetesClusterExtensionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                KubernetesClusterExtensionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListExtensions()
        {
            // Generated from example definition: specification/kubernetesconfiguration/resource-manager/Microsoft.KubernetesConfiguration/stable/2022-11-01/examples/ListExtensions.json
            // this example is just showing the usage of "Extensions_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId1";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this KubernetesClusterExtensionResource
            string clusterRp = "Microsoft.Kubernetes";
            string clusterResourceName = "connectedClusters";
            string clusterName = "clusterName1";
            KubernetesClusterExtensionCollection collection = resourceGroupResource.GetKubernetesClusterExtensions(clusterRp, clusterResourceName, clusterName);

            // invoke the operation and iterate over the result
            await foreach (KubernetesClusterExtensionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                KubernetesClusterExtensionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
