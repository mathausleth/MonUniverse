namespace MonUniverse.MonUniverseService
{
    public enum State
    {
        COLLECT_CONNECTIONS,
        COLLECT_IPS,
        PROCESS_CORELLATION,
        READ_DNS_CACHE,
        READ_AND_CLEAR_LOGS,
        REFRESH_DNS_CACHE
    }
}