﻿namespace Slqsh;

[AttributeUsage(AttributeTargets.Parameter)]
public sealed class AutoCompleteAttribute : Attribute
{
    public AutoCompleteAttribute()
        : this(default)
    { }

    public AutoCompleteAttribute(Type overrideAutoCompleteType)
    {
        OverrideAutoCompleteType = overrideAutoCompleteType;
    }

    public Type OverrideAutoCompleteType { get; }
}