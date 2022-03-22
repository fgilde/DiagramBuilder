using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace DiagramBuilder
{
    public class FileUtil
    {
        public static async Task SaveAs(IJSRuntime js, string data, string fileName)
        {
            await js.InvokeAsync<object>("saveDiagram", Convert.ToString(data), fileName).ConfigureAwait(true);
        }
        public static async Task Click(IJSRuntime js)
        {
            await js.InvokeAsync<object>("click").ConfigureAwait(true);
        }
        public static async Task<string> LoadFile(IJSRuntime js, object data)
        {
            return await js.InvokeAsync<string>("loadFile", data).ConfigureAwait(true);
        }

        public static async Task SetGradient(IJSRuntime js, int level)
        {
            await js.InvokeAsync<object>("setWaterLevel", level).ConfigureAwait(true);
        }
    }
}
