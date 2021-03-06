﻿namespace WaveTech.Dafuscator.Model.Interfaces.Providers
{
	public interface IObjectSerializationProvider
	{
		string Serialize(object o);
		T Deserialize<T>(string o);
	}
}