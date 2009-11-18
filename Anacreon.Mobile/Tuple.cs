using System;

namespace Anacreon.Mobile
{
	struct Tuple<T1,T2>
	{
		static Tuple<T1, T2> m_empty = new Tuple<T1, T2>();

		public static Tuple<T1, T2> Empty { get { return m_empty; } }

		public Tuple(T1 v1, T2 v2) : this()
		{
			Value1 = v1;
			Value2 = v2;
		}

		public T1 Value1 { get; set; }

		public T2 Value2 { get; set; }

	}

	struct Tuple<T1, T2, T3>
	{
		static Tuple<T1, T2, T3> m_empty = new Tuple<T1,T2,T3>();

		public static Tuple<T1, T2, T3> Empty { get { return m_empty; } }

		public Tuple(T1 v1, T2 v2, T3 v3) : this()
		{
			Value1 = v1;
			Value2 = v2;
			Value3 = v3;
		}

		public T1 Value1 { get; set; }

		public T2 Value2 { get; set; }

		public T3 Value3 { get; set; }

	}

}
