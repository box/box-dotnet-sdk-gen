namespace Box.Sdk.Gen {
    public class OneOf<T0,T1,T2,T3,T4> {
#if NETSTANDARD2_0
        protected T0 _val0 { get; }
#else
        protected T0? _val0 { get; }
#endif
        
#if NETSTANDARD2_0
        protected T1 _val1 { get; }
#else
        protected T1? _val1 { get; }
#endif
        
#if NETSTANDARD2_0
        protected T2 _val2 { get; }
#else
        protected T2? _val2 { get; }
#endif
        
#if NETSTANDARD2_0
        protected T3 _val3 { get; }
#else
        protected T3? _val3 { get; }
#endif
        
#if NETSTANDARD2_0
        protected T4 _val4 { get; }
#else
        protected T4? _val4 { get; }
#endif
        
        protected OneOf (T0 value) { _val0 = value; }
        
        protected OneOf (T1 value) { _val1 = value; }
        
        protected OneOf (T2 value) { _val2 = value; }
        
        protected OneOf (T3 value) { _val3 = value; }
        
        protected OneOf (T4 value) { _val4 = value; }
        
        public static implicit operator OneOf<T0,T1,T2,T3,T4>(T0 value) => new OneOf<T0,T1,T2,T3,T4>(value);
        
        public static implicit operator OneOf<T0,T1,T2,T3,T4>(T1 value) => new OneOf<T0,T1,T2,T3,T4>(value);
        
        public static implicit operator OneOf<T0,T1,T2,T3,T4>(T2 value) => new OneOf<T0,T1,T2,T3,T4>(value);
        
        public static implicit operator OneOf<T0,T1,T2,T3,T4>(T3 value) => new OneOf<T0,T1,T2,T3,T4>(value);
        
        public static implicit operator OneOf<T0,T1,T2,T3,T4>(T4 value) => new OneOf<T0,T1,T2,T3,T4>(value);
    }
}