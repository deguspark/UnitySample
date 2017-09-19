using System.Runtime.InteropServices;

public class NativeUtils {

	#if UNITY_IOS
	[DllImport("__Internal")]
	#else
	[DllImport("Native")]
	#endif
	private static extern int com_shogonir_Native_FourFours();

	public static int FourFours() {
		return com_shogonir_Native_FourFours();
	}
}
