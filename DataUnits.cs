namespace DataValue
{
	/// <summary>
	/// Provides a means to identify a data unit.
	/// </summary>
	[Flags]
	public enum DataUnits
	{
		/// <summary>
		/// Represents the numerical value is measured in bytes (8 bits).
		/// </summary>
		B=0x0,
		/// <summary>
		/// Indicates the value has been simplified by a given factor.
		/// </summary>
		KB=0x1,
		/// <inheritdoc cref="Kilo"/>
		MB=0x2,
		/// <inheritdoc cref="Kilo"/>
		GB=0x4,
		/// <inheritdoc cref="Kilo"/>
		TB=0x8,
		/// <inheritdoc cref="Kilo"/>
		PB=0x10,
		/// <inheritdoc cref="Kilo"/>
		EB=0x20,
		/// <inheritdoc cref="Kilo"/>
		ZB=0x40,
		/// <inheritdoc cref="Kilo"/>
		YB=0x80,
		/// <inheritdoc cref="Kilo"/>
		BB=0x100,

	}
}
