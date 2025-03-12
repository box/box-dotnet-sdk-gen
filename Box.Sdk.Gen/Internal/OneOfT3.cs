namespace Box.Sdk.Gen {
    public class OneOf<T0,T1,T2> {
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
        
        protected OneOf (T0 value) { _val0 = value; }
        
        protected OneOf (T1 value) { _val1 = value; }
        
        protected OneOf (T2 value) { _val2 = value; }
        
        public static implicit operator OneOf<T0,T1,T2>(T0 value) => new OneOf<T0,T1,T2>(value);
        
        public static implicit operator OneOf<T0,T1,T2>(T1 value) => new OneOf<T0,T1,T2>(value);
        
        public static implicit operator OneOf<T0,T1,T2>(T2 value) => new OneOf<T0,T1,T2>(value);
    }
}