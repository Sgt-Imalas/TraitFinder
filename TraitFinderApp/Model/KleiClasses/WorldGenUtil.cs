﻿using TraitFinderApp.Client.Model.KleiClasses;

namespace TraitFinderApp.Model.KleiClasses
{
	public static class WorldGenUtil
	{
		public static void ShuffleSeeded<T>(this IList<T> list, KRandom rng)
		{
			int num = list.Count;
			while (num > 1)
			{
				num--;
				int index = rng.Next(num + 1);
				T value = list[index];
				list[index] = list[num];
				list[num] = value;
			}
		}
	}
}
